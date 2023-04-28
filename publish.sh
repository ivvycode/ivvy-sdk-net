#!/usr/bin/env bash

EXIT_SUCCESS=0
EXIT_ERR_NO_SOURCE=1
EXIT_ERR_SOURCE_PERMS=2
EXIT_ERR_NO_NUGET_KEY=3
EXIT_ERR_BAD_DIR=4
EXIT_ERR_ABORT=5
EXIT_ERR_BUILD=6
EXIT_ERR_GIT=7

function load_nuget_env()
{
    [ ! -f ~/.ivvy_nuget.source ] && echo "Could not find source file ~/.ivvy_nuget.source" && exit $EXIT_ERR_NO_SOURCE
    local octal_access=`stat -c '%a' ~/.ivvy_nuget.source`
    [ ! $octal_access == "400" ] && echo "Source file ~/.ivvy_nuget.source should have 400 permissions" && exit $EXIT_ERR_SOURCE_PERMS
    source ~/.ivvy_nuget.source
}

function check_nuget_env()
{
    [ -z "$IVVY_NUGET_KEY" ] && echo "iVvy nuget key is required" && exit $EXIT_ERR_NO_NUGET_KEY
}

function get_package_version()
{
    echo `grep -oPm1 "(?<=<VersionPrefix>)[^<]+" src/Ivvy.API.csproj`
}

[ ! -f src/Ivvy.API.csproj ] && echo "Script must be run from project root" && exit $EXIT_ERR_BAD_DIR

git checkout main && git pull
[[ $? != 0 ]] && exit $EXIT_ERR_GIT

load_nuget_env
check_nuget_env

package_version=$(get_package_version)
read -p "Confirm publish version $package_version (yes|no)? " accept
[[ $accept != "yes" ]] && echo "Aborted" && exit $EXIT_ERR_ABORT

dotnet pack -c Release
[[ $? != 0 ]] && exit $EXIT_ERR_BUILD

dotnet nuget push \
    "src/bin/Release/Ivvy.API.$package_version.nupkg" \
    -k $IVVY_NUGET_KEY \
    -s https://api.nuget.org/v3/index.json
[[ $? != 0 ]] && exit $EXIT_ERR_BUILD

exit $EXIT_SUCCESS
