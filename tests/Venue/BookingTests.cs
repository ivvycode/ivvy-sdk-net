using System;
using System.Collections.Generic;
using Ivvy.API.Json.Converters;
using Ivvy.API.Venue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Xunit;

namespace Ivvy.API.UnitTests.Venue
{
    public class BookingTests
    {
        [Fact]
        public void Booking_WithoutReservationMethods_DeserializedCorrectly()
        {
            var booking = new Booking
            {
                Id = 42
            };
            var bookingAsString = SerializeBooking(booking);
            var response = GetBookingResultOrError(bookingAsString);

            Assert.Null(response.Result.AccommodationReservationMethods);
        }

        [Fact]
        public void Booking_WithEmptyReservationMethods_DeserializedCorrectly()
        {
            var booking = new Booking
            {
                Id = 42,
                AccommodationReservationMethods =
                    Array.Empty<Booking.AccommodationReservationMethodOptions>()
            };
            var bookingAsString = SerializeBooking(booking);
            var response = GetBookingResultOrError(bookingAsString);

            Assert.Empty(response.Result.AccommodationReservationMethods);
        }

        [Fact]
        public void Booking_WithReservationMethods_DeserializedCorrectly()
        {
            var booking = new Booking
            {
                Id = 42,
                AccommodationReservationMethods =
                    new Booking.AccommodationReservationMethodOptions[]
                    {
                        Booking.AccommodationReservationMethodOptions.RoomingList,
                        Booking.AccommodationReservationMethodOptions.BookingEngine,
                    }
            };
            var bookingAsString = SerializeBooking(booking);
            var response = GetBookingResultOrError(bookingAsString);

            Assert.Contains(
                response.Result.AccommodationReservationMethods,
                rm => rm == Booking.AccommodationReservationMethodOptions.RoomingList);

            Assert.Contains(
                response.Result.AccommodationReservationMethods,
                rm => rm == Booking.AccommodationReservationMethodOptions.BookingEngine);
        }

        private ResultOrError<Booking> GetBookingResultOrError(string bookingAsString)
        {
            return JsonConvert.DeserializeObject<ResultOrError<Booking>>(
                bookingAsString, new ResponseConverter<Booking>());
        }

        private string SerializeBooking(Booking booking)
        {
            return JsonConvert.SerializeObject(
                booking,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>()
                    {
                        new IsoDateTimeConverter()
                        {
                            DateTimeFormat = Utils.DateTimeFormat
                        }
                    }
                });
        }
    }
}