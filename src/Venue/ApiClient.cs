using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Venue;
using Ivvy.API.Venue.ARI;
using Ivvy.API.Venue.Bookings;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        public async Task<ResultOrError<Venue.Venue>> GetVenueAsync(
            int id)
        {
            return await CallAsync<Venue.Venue>(
                "venue", "getVenue", new
                {
                    id,
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await CallAsync<ResultList<Venue.Room>>(
                "venue", "getVenueRoomList", new
                {
                    venueId,
                    perPage,
                    start,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.RoomOption>>> GetVenueRoomOptionListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await CallAsync<ResultList<Venue.RoomOption>>(
                "venue", "getVenueRoomOptionList", new
                {
                    venueId,
                    perPage,
                    start,
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await CallAsync<ResultList<Venue.RatePlan>>(
                "venue", "getVenueRatePlanList", new
                {
                    venueId,
                    perPage,
                    start,
                }
            );
        }

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        public async Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id)
        {
            return await CallAsync<Venue.Booking>(
                "venue", "getBooking", new
                {
                    venueId,
                    id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<AddUpdateBookingResult>> AddOrUpdateVenueBookingAsync(Venue.Booking booking)
        {
            return await CallAsync<AddUpdateBookingResult>(
                "venue", "addOrUpdateBooking", booking
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Accommodation>>> GetVenueBookingAccommodationListAsync(
            int venueId,
            int bookingId)
        {
            return await CallAsync<ResultList<Accommodation>>(
                "venue", "getBookingAccommodationList", new
                {
                    venueId,
                    bookingId,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.Note>>> GetVenueBookingNoteListAsync(
            int venueId,
            int bookingId,
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Venue.Note>>(
                "venue", "getBookingNoteList", new
                {
                    venueId,
                    bookingId,
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateVenueBookingAccommodationAsync(
            Accommodation group)
        {
            // Null out the group properties that cannot be added/updated.
            group.CostCenterId = null;
            group.CreatedDate = null;
            group.ModifiedDate = null;
            if (group.DayRates != null)
            {
                foreach (var dayRate in group.DayRates)
                {
                    if (dayRate != null)
                    {
                        dayRate.NumFreeRooms = null;
                    }
                }
            }
            if (group.RoomOptions != null)
            {
                foreach (var roomOpt in group.RoomOptions)
                {
                    if (roomOpt != null)
                    {
                        roomOpt.TotalAmount = null;
                        roomOpt.TotalTaxAmount = null;
                    }
                }
            }

            return await CallAsync<ResultObject>(
                "venue", "addOrUpdateBookingAccommodation", group
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<RemoveBookingAccommodationResult>> RemoveVenueBookingAccommodationAsync(
            int venueId,
            int bookingId,
            int id)
        {
            return await CallAsync<RemoveBookingAccommodationResult>(
                "venue", "removeBookingAccommodation", new
                {
                    venueId,
                    bookingId,
                    id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<RoomReservation>>> GetVenueBookingRoomReservationListAsync(
            int venueId,
            int perPage,
            int start,
            int? bookingId,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<RoomReservation>>(
                "venue", "getBookingRoomReservationList", new
                {
                    venueId,
                    bookingId,
                    start,
                    perPage,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<RoomReservation>> GetVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int reservationId)
        {
            var listResult = await GetVenueBookingRoomReservationListAsync(
                venueId, 1, 0, bookingId, new Dictionary<string, object>() {
                    { "id", reservationId }
                }
            );
            var newResult = new ResultOrError<RoomReservation>()
            {
                ErrorCode = listResult.ErrorCode,
                ErrorCodeSpecific = listResult.ErrorCodeSpecific,
                ErrorMessage = listResult.ErrorMessage
            };
            if (listResult.IsSuccess())
            {
                if (listResult.Result.Meta.Count == 1)
                {
                    newResult.Result = listResult.Result.Results[0];
                }
                else
                {
                    newResult.ErrorCode = libErrorCode;
                    newResult.ErrorMessage = "The room reservation does not exist";
                }
            }
            return newResult;
        }

        /// <inheritdoc />
        public async Task<ResultOrError<AddUpdateBookingRoomReservationResult>> AddOrUpdateVenueBookingRoomReservationAsync(
            RoomReservation reservation)
        {
            // Null out the reservation properties that cannot be added/updated.
            reservation.Reference = null;
            reservation.MainGuestId = null;
            if (reservation.MainGuest != null)
            {
                reservation.MainGuest.CreatedDate = null;
                reservation.MainGuest.ModifiedDate = null;
                if (reservation.MainGuest.Contact != null)
                {
                    reservation.MainGuest.Contact.CreatedDate = null;
                    reservation.MainGuest.Contact.ModifiedDate = null;
                }
            }
            reservation.CurrentStatus = null;
            reservation.CancelledDate = null;
            reservation.IsFromGroup = null;
            reservation.TotalAmount = null;
            reservation.CreatedDate = null;
            reservation.ModifiedDate = null;
            if (reservation.Rooms != null)
            {
                foreach (var room in reservation.Rooms)
                {
                    if (room == null)
                    {
                        continue;
                    }
                    room.GuestId = null;
                    if (room.Guest != null)
                    {
                        room.Guest.CreatedDate = null;
                        room.Guest.ModifiedDate = null;
                        if (room.Guest.Contact != null)
                        {
                            room.Guest.Contact.CreatedDate = null;
                            room.Guest.Contact.ModifiedDate = null;
                        }
                    }
                    room.RatePlanId = null;
                    room.RoomId = null;
                    room.NumRooms = null;
                    room.TotalAmount = null;
                    room.CreatedDate = null;
                    room.ModifiedDate = null;
                    room.IsCancelled = null;
                    room.CancelledDate = null;
                    if (room.DayRates != null)
                    {
                        foreach (var rate in room.DayRates)
                        {
                            if (rate == null)
                            {
                                continue;
                            }
                            rate.RatePlanId = null;
                        }
                    }
                    if (room.AdditionalGuests != null)
                    {
                        foreach (var additionalGuest in room.AdditionalGuests)
                        {
                            if (additionalGuest == null)
                            {
                                continue;
                            }
                            if (additionalGuest.Guest != null)
                            {
                                additionalGuest.Guest.CreatedDate = null;
                                additionalGuest.Guest.ModifiedDate = null;
                                if (additionalGuest.Guest.Contact != null)
                                {
                                    additionalGuest.Guest.Contact.CreatedDate = null;
                                    additionalGuest.Guest.Contact.ModifiedDate = null;
                                }
                            }
                        }
                    }
                }
            }

            return await CallAsync<AddUpdateBookingRoomReservationResult>(
                "venue", "addOrUpdateBookingRoomReservation", reservation
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<RemoveBookingRoomReservationResult>> RemoveVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id)
        {
            return await CallAsync<RemoveBookingRoomReservationResult>(
                "venue", "removeBookingRoomReservation", new
                {
                    venueId,
                    bookingId,
                    id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ConfirmBookingRoomReservationResult>> ConfirmVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id,
            int[] roomIds = null)
        {
            return await CallAsync<ConfirmBookingRoomReservationResult>(
                "venue", "confirmBookingRoomReservation", new
                {
                    venueId,
                    bookingId,
                    id,
                    roomIds,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<CancelBookingRoomReservationResult>> CancelVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id,
            int? roomId = null)
        {
            return await CallAsync<CancelBookingRoomReservationResult>(
                "venue", "cancelBookingRoomReservation", new
                {
                    venueId,
                    bookingId,
                    id,
                    roomId,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ChangeStatusOfBookingRoomReservationResult>> ChangeStatusOfBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id,
            RoomReservation.StatusOptions newStatus,
            int[] roomIds = null)
        {
            return await CallAsync<ChangeStatusOfBookingRoomReservationResult>(
                "venue", "changeStatusOfBookingRoomReservation", new
                {
                    venueId,
                    bookingId,
                    id,
                    status = newStatus,
                    roomIds,
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy venue.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListAsync(
            int venueId,
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingList", new
                {
                    venueId,
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy account.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListForAccountAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingListForAccount", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        [Obsolete("Use AddOrUpdateVenueRoomCountsCollection() instead")]
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCounts(
            int venueId,
            int roomId,
            string startDate,
            string endDate,
            int roomCount)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomCounts", new
                {
                    venueId,
                    roomId,
                    startDate,
                    endDate,
                    roomCount,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCountsCollection(
            int venueId,
            List<RoomCount> items)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomCountsCollection", new
                {
                    venueId,
                    items,
                }
            );
        }

        /// <inheritdoc />
        [Obsolete("Use AddOrUpdateVenueRoomDynamicRatesCollection() instead")]
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            double cost)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomDynamicRates", new
                {
                    venueId,
                    barId = ratePlanId,
                    roomId,
                    startDate,
                    endDate,
                    cost,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRatesCollection(
            int venueId,
            List<RatePlanRoomRate> items)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomDynamicRatesCollection", new
                {
                    venueId,
                    items,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> RemoveVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "removeRoomDynamicRates", new
                {
                    venueId,
                    barId = ratePlanId,
                    roomId,
                    startDate,
                    endDate,
                }
            );
        }

        /// <inheritdoc />
        [Obsolete("Use AddOrUpdateVenueRatePlanRulesCollection() instead")]
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRules(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            Venue.RatePlan.CloseOutStatusOptions closeOutStatus)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRatePlanBookingRules", new
                {
                    venueId,
                    barId = ratePlanId,
                    roomId,
                    startDate,
                    endDate,
                    closeOutStatus,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRulesCollection(
            int venueId,
            List<RatePlanBookingRule> items)
        {
            return await CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRatePlanBookingRulesCollection", new
                {
                    venueId,
                    items,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.Tax>>> GetVenueTaxListAsync(int venueId)
        {
            return await CallAsync<ResultList<Venue.Tax>>(
                "venue", "getTaxList", new
                {
                    venueId,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.CostCenter>>> GetVenueCostCenterListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await CallAsync<ResultList<Venue.CostCenter>>(
                "venue", "getCostCenterList", new
                {
                    venueId,
                    perPage,
                    start,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> ChangeBookingStatusAsync(
            ChangeBookingStatusRequest request)
        {
            return await CallAsync<ResultObject>(
                "venue", "changeBookingStatus", request);
        }
    }
}