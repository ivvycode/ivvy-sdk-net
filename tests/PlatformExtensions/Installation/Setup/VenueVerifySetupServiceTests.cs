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
    public class VenueVerifySetupServiceTests
    {
        [Theory]
        [MemberData(nameof(VerifySetupAsync_DataProvider))]
        public async Task VerifySetupAsync(
            VenueVerifySetupResponse expectedResult,
            Mock<IPlatformExtension> mockExtension,
            VenueSetupRequest setupRequest,
            string ivvyVenueSetupVerifyUrl)
        {
            // ARRANGE

            var verifySetup = new Mock<VenueVerifySetupService>();
            verifySetup
                .Setup(vs => vs.NewPlatformExtension())
                .Returns(mockExtension.Object);

            // ACT

            var actualResult = await verifySetup.Object.VerifySetupAsync(
                setupRequest, ivvyVenueSetupVerifyUrl
            );

            // ASSERT

            actualResult.Should().BeEquivalentTo(expectedResult);
        }
        public static IEnumerable<object[]> VerifySetupAsync_DataProvider()
        {
            // SCENARIO: An unsuccessful setup verification result.
            // EXPECT: Null to be returned.
            var unsuccessfulResponse = new ResultOrError<VenueVerifySetupResponse>
            {
                Success = false,
                Result = null,
                ErrorMessage = "Hmm, something went wrong.",
            };
            var mockExtension1 = new Mock<IPlatformExtension>();
            mockExtension1
                .Setup(ext => ext.VenueVerifySetupAsync("123", "456", "abcdefg"))
                .ReturnsAsync(unsuccessfulResponse);
            yield return new object[]
            {
                null,
                mockExtension1,
                new VenueSetupRequest
                {
                    Region = "ap-southeast-2",
                    AccountId = "123",
                    VenueId = "456",
                    SetupKey = "abcdefg",
                },
                "https://www.ivvy.com.au/extension/venue-verify",
            };

            // SCENARIO: A successful setup verification result.
            // EXPECT: A verification response.
            var successfulResponse = new ResultOrError<VenueVerifySetupResponse>
            {
                Success = true,
                Result = new VenueVerifySetupResponse
                {
                    AccountId = "123",
                    AccountDomain = "test.com",
                    VenueId = "456",
                    VenueHashId = "venuehashid",
                },
            };
            var mockExtension2 = new Mock<IPlatformExtension>();
            mockExtension2
                .Setup(ext => ext.VenueVerifySetupAsync("123", "456", "abcdefg"))
                .ReturnsAsync(successfulResponse);
            yield return new object[]
            {
                new VenueVerifySetupResponse
                {
                    AccountId = "123",
                    AccountDomain = "test.com",
                    VenueId = "456",
                    VenueHashId = "venuehashid",
                },
                mockExtension2,
                new VenueSetupRequest
                {
                    Region = "ap-southeast-2",
                    AccountId = "123",
                    VenueId = "456",
                    SetupKey = "abcdefg",
                },
                "https://www.ivvy.com.au/extension/venue-verify",
            };
        }
    }
}