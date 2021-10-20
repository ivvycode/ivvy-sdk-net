using System;
using System.Collections.Generic;
using Ivvy.API.Venue.Bookings;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace Ivvy.API.UnitTests
{
    public class ApiClientSerializerTests
    {
        private readonly ApiClient apiClient;
        private readonly Mock<IApiClientEvents> events;

        private string lastPostData;

        public ApiClientSerializerTests()
        {
            events = new Mock<IApiClientEvents>();
            apiClient = new ApiClient(events.Object)
            {
                BaseUrl = "http://localhost",
                ApiKey = "apiKey",
                ApiSecret = "apiSecret"
            };

            events.Setup(e => e.BeforeApiCalledAsync(It.IsAny<ApiCallRequestDetails>()))
                .Callback<ApiCallRequestDetails>(a => lastPostData = a.RequestBody);
        }

        [Theory]
        [MemberData(nameof(JsonConvert_SerializeDateAndTimeValues_MatchesExpectedDataProvider))]
        public async void JsonConvert_SerializeDateAndTimeValues_MatchesExpected(Session session, Dictionary<string, string> expectedResult)
        {
            // Note that the usage of the Session class here is because it has date and time fields
            await apiClient.CallAsync<object>("test", "test", session);

            var serialized = JsonConvert.SerializeObject(
                expectedResult,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                }
            );

            // Strip the { } from start and end of serialized substring
            Assert.Contains(serialized.TrimStart('{').TrimEnd('}'), lastPostData);
        }

        [Theory]
        [MemberData(nameof(JsonConvert_SerializeDateTimeValues_MatchesExpectedDataProvider))]
        public async void JsonConvert_SerializeDateTimeValues_MatchesExpected(
            Event.Event data,
            Dictionary<string, string> expectedResult)
        {
            // Note that the usage of the Event class here is because it has dateTime fields
            await apiClient.CallAsync<object>("test", "test", data);

            var serialized = JsonConvert.SerializeObject(
                expectedResult,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                }
            );

            // Strip the { } from start and end of serialized substring
            Assert.Contains(serialized.TrimStart('{').TrimEnd('}'), lastPostData);
        }

        public static IEnumerable<object[]> JsonConvert_SerializeDateAndTimeValues_MatchesExpectedDataProvider()
        {
            var today = DateTime.Today;
            var now = DateTime.Now;
            var utcNow = DateTime.UtcNow;

            yield return new object[]
            {
                new Session
                {
                    StartDate = now,
                    StartTime = utcNow,
                },
                new Dictionary<string, string>()
                {
                    {"startDate", now.ToString("yyyy-MM-dd") },
                    {"startTime", utcNow.ToString("HH:mm:ss") }
                }
            };

            yield return new object[]
            {
                new Session
                {
                    StartDate = now,
                    StartTime = today.AddHours(10),
                },
                new Dictionary<string, string>()
                {
                    {"startDate", now.ToString("yyyy-MM-dd") },
                    {"startTime", today.AddHours(10).ToString("HH:mm:ss") }
                }
            };

            yield return new object[]
            {
                new Session
                {
                    StartDate = today,
                    StartTime = utcNow,
                },
                new Dictionary<string, string>()
                {
                    {"startDate", today.ToString("yyyy-MM-dd") },
                    {"startTime", utcNow.ToString("HH:mm:ss") }
                }
            };

            yield return new object[]
            {
                new Session
                {
                    StartDate = today.AddDays(2),
                    StartTime = now,
                },
                new Dictionary<string, string>()
                {
                    {"startDate", today.AddDays(2).ToString("yyyy-MM-dd") },
                    {"startTime", now.ToString("HH:mm:ss") }
                }
            };
        }

        public static IEnumerable<object[]> JsonConvert_SerializeDateTimeValues_MatchesExpectedDataProvider()
        {
            var today = DateTime.Today;
            var now = DateTime.Now;
            var utcNow = DateTime.UtcNow;

            yield return new object[]
            {
                new Event.Event
                {
                    StartDateTime = now,
                    EndDateTime = now.AddMinutes(75),
                },
                new Dictionary<string, string>()
                {
                    {"startDateTime", now.ToString("yyyy-MM-dd HH:mm:ss UTC") },
                    {"endDateTime", now.AddMinutes(75).ToString("yyyy-MM-dd HH:mm:ss UTC") }
                }
            };

            yield return new object[]
            {
                new Event.Event
                {
                    StartDateTime = today,
                    EndDateTime = today.AddHours(10),
                },
                new Dictionary<string, string>()
                {
                    {"startDateTime", today.ToString("yyyy-MM-dd HH:mm:ss UTC") },
                    {"endDateTime", today.AddHours(10).ToString("yyyy-MM-dd HH:mm:ss UTC") },
                }
            };

            yield return new object[]
            {
                new Event.Event
                {
                    StartDateTime = utcNow,
                    EndDateTime = utcNow.AddDays(1),
                },
                new Dictionary<string, string>()
                {
                    {"startDateTime", utcNow.ToString("yyyy-MM-dd HH:mm:ss UTC") },
                    {"endDateTime", utcNow.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss UTC") },
                }
            };

            yield return new object[]
            {
                new Event.Event
                {
                    StartDateTime = today.AddDays(2),
                    EndDateTime = today.AddDays(3),
                },
                new Dictionary<string, string>()
                {
                    {"startDateTime", today.AddDays(2).ToString("yyyy-MM-dd HH:mm:ss UTC") },
                    {"endDateTime", today.AddDays(3).ToString("yyyy-MM-dd HH:mm:ss UTC") },
                }
            };
        }
    }
}
