using System;
using System.Collections.Generic;
using Ivvy.API.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Xunit;

namespace Ivvy.API.UnitTests
{
    public class DeserializerTests
    {
        [Theory]
        [MemberData(nameof(JsonConvert_DeserializesUnexpectedNull_DateTimeValues_DataProvider))]
        public void JsonConvert_DeserializesUnexpectedNull_DateTimeValues(string data, Event.Event expectedResult)
        {
            // Note that the usage of the Event class here is because it has date fields
            var result =
                JsonConvert.DeserializeObject<ResultOrError<Event.Event>>(
                    data,
                    new ResponseConverter<Event.Event>());

            Assert.Equal(expectedResult.Id, result.Result.Id);
            Assert.Equal(AdjustToNearestSecond(expectedResult.StartDateTime),result.Result.StartDateTime);
            Assert.Equal(AdjustToNearestSecond(expectedResult.EndDateTime), result.Result.EndDateTime);
        }

        [Theory]
        [MemberData(nameof(JsonConvert_DeserializesUnexpectedNull_IntegerValues_DataProvider))]
        public void JsonConvert_DeserializesUnexpectedNull_IntegerValues(string data, Event.Event expectedResult)
        {
            // Note that the usage of the Event class here is because it has date fields
            var result =
                JsonConvert.DeserializeObject<ResultOrError<Event.Event>>(
                    data,
                    new ResponseConverter<Event.Event>());

            Assert.Equal(expectedResult.Id, result.Result.Id);
            Assert.Equal(0,result.Result.Capacity);
        }

        private static DateTime? AdjustToNearestSecond(DateTime? preciseDateTime)
        {
            if (preciseDateTime == null)
            {
                return null;
            }
            return ((DateTime)preciseDateTime).AddTicks( -1 * (((DateTime)preciseDateTime).Ticks % TimeSpan.TicksPerSecond));
        }

        public static IEnumerable<object[]> JsonConvert_DeserializesUnexpectedNull_DateTimeValues_DataProvider()
        {
            var nullDatesEvent = new Event.Event
            {
                Id = "eventId",
            };
            var nullDatesEventAsString = JsonConvert.SerializeObject(
                new ResultOrError<Event.Event> {Result = nullDatesEvent},
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Converters = new List<JsonConverter>()
                        { new IsoDateTimeConverter() { DateTimeFormat = Utils.DateTimeFormat } }
                }
            );

            yield return new object[]
            {
                nullDatesEventAsString,
                nullDatesEvent
            };

            var nonNullDatesEvent = new Event.Event
            {
                Id = "47",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.MaxValue
            };
            var nonNullDatesEventAsString = JsonConvert.SerializeObject(
                new ResultOrError<Event.Event> {Result = nonNullDatesEvent},
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Converters = new List<JsonConverter>()
                        { new IsoDateTimeConverter() { DateTimeFormat = Utils.DateTimeFormat } }
                }
            );

            yield return new object[]
            {
                nonNullDatesEventAsString,
                nonNullDatesEvent
            };
        }

        public static IEnumerable<object[]> JsonConvert_DeserializesUnexpectedNull_IntegerValues_DataProvider()
        {
            var nullCapacityEvent = new Event.Event
            {
                Id = "eventId",
                Capacity = int.MaxValue
            };
            var nullCapacityEventAsString = JsonConvert.SerializeObject(
                new ResultOrError<Event.Event> {Result = nullCapacityEvent},
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Converters = new List<JsonConverter>()
                        { new IsoDateTimeConverter() { DateTimeFormat = Utils.DateTimeFormat } }
                }
            );

            yield return new object[]
            {
                // dates can come from API as actually null string, however our conversion inserted
                // the default date/time string so replace that for test purposes
                nullCapacityEventAsString.Replace(int.MaxValue.ToString(), "null"),
                nullCapacityEvent
            };
        }
    }
}
