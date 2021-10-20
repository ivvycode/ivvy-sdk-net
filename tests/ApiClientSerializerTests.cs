using System;
using System.Collections.Generic;
using Ivvy.API.Json;
using Ivvy.API.Venue.Bookings;
using Newtonsoft.Json;
using Xunit;

namespace Ivvy.API.UnitTests
{
    public class ApiClientSerializerTests
    {
        private readonly IApiClientSerializer serializer;

        public ApiClientSerializerTests()
        {
            serializer = new ApiClientSerializer();
        }

        [Theory]
        [MemberData(nameof(SerializeDateAndTimeValues_MatchesExpectedDataProvider))]
        public void SerializeDateAndTimeValues_MatchesExpected(Session session, Dictionary<string, string> expectedResult)
        {
            // Note that the usage of the Session class here is because it has date and time fields
            var result = serializer.Serialize(session);

            var serialized = JsonConvert.SerializeObject(
                expectedResult,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                }
            );

            // Strip the { } from start and end of serialized substring
            Assert.Contains(serialized.TrimStart('{').TrimEnd('}'), result);
        }

        [Theory]
        [MemberData(nameof(SerializeDateTimeValues_MatchesExpectedDataProvider))]
        public  void SerializeDateTimeValues_MatchesExpected(
            Event.Event data,
            Dictionary<string, string> expectedResult)
        {
            // Note that the usage of the Event class here is because it has dateTime fields
            var result = serializer.Serialize(data);

            var serialized = JsonConvert.SerializeObject(
                expectedResult,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                }
            );

            // Strip the { } from start and end of serialized substring
            Assert.Contains(serialized.TrimStart('{').TrimEnd('}'), result);
        }

        public static IEnumerable<object[]> SerializeDateAndTimeValues_MatchesExpectedDataProvider()
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

        public static IEnumerable<object[]> SerializeDateTimeValues_MatchesExpectedDataProvider()
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
