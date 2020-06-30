using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Ivvy.PlatformExtensions;
using Ivvy.PlatformExtensions.Installation;
using Ivvy.PlatformExtensions.Installation.Setup;
using Moq;
using Xunit;

namespace Ivvy.Tests.PlatformExtensions.Setup
{
    public class VerifySetupServiceTests
    {
        [Theory]
        [MemberData(nameof(VerifySetupAsync_DataProvider))]
        public async Task VerifySetupAsync(
            VerifySetupResponse expectedResult,
            Mock<IPlatformExtension> mockExtension,
            SetupRequest setupRequest)
        {
            // ARRANGE

            var verifySetup = new Mock<VerifySetupService>();
            verifySetup
                .Setup(vs => vs.NewPlatformExtension())
                .Returns(mockExtension.Object);

            // ACT

            var actualResult = await verifySetup.Object.VerifySetupAsync(setupRequest);

            // ASSERT

            actualResult.Should().BeEquivalentTo(expectedResult);
        }
        public static IEnumerable<object[]> VerifySetupAsync_DataProvider()
        {
            // SCENARIO: An unsuccessful setup verification result.
            // EXPECT: Null to be returned, and an error to be logged.
            var unsuccessfulResponse = new ResultOrError<VerifySetupResponse>
            {
                Success = false,
                Result = null,
                ErrorMessage = "Hmm, something went wrong.",
            };
            var mockExtension1 = new Mock<IPlatformExtension>();
            mockExtension1
                .Setup(ext => ext.VerifySetupAsync("123", "abcdefg"))
                .ReturnsAsync(unsuccessfulResponse);
            yield return new object[]
            {
                null,
                mockExtension1,
                new SetupRequest {
                    AccountId = "123",
                    SetupKey = "abcdefg",
                },
            };

            // SCENARIO: A successful setup verification result.
            // EXPECT: A verification response, and no errors to be logged.
            var successfulResponse = new ResultOrError<VerifySetupResponse>
            {
                Success = true,
                Result = new VerifySetupResponse
                {
                    AccountId = "202",
                    AccountDomain = "test.com",
                    ApiKey = "the_api_key",
                    ApiSecret = "the_api_secret",
                },
            };
            var mockExtension2 = new Mock<IPlatformExtension>();
            mockExtension2
                .Setup(ext => ext.VerifySetupAsync("202", "hijklmnop"))
                .ReturnsAsync(successfulResponse);
            yield return new object[]
            {
                new VerifySetupResponse
                {
                    AccountId = "202",
                    AccountDomain = "test.com",
                    ApiKey = "the_api_key",
                    ApiSecret = "the_api_secret",
                },
                mockExtension2,
                new SetupRequest
                {
                    AccountId = "202",
                    SetupKey = "hijklmnop",
                },
            };
        }

        [Fact]
        public void NewExtension_ReturnsNewExtension()
        {
            // ARRANGE

            var verifySetup = new VerifySetupService();

            // ACT

            var actualResult = verifySetup.NewPlatformExtension();

            // ASSERT

            Assert.NotNull(actualResult);
            actualResult.Should().BeEquivalentTo(new PlatformExtension());
        }
    }
}