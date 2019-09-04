using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        public async Task<ResultOrError<Venue.Venue>> GetVenueAsync(
            int id)
        {
            return await this.CallAsync<Venue.Venue>(
                "venue", "getVenue", new { id = id }
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
            return await this.CallAsync<ResultList<Venue.Room>>(
                "venue", "getVenueRoomList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.RoomOption>>> GetVenueRoomOptionListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Venue.RoomOption>>(
                "venue", "getVenueRoomOptionList", new { venueId = venueId, perPage = perPage, start = start }
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
            return await this.CallAsync<ResultList<Venue.RatePlan>>(
                "venue", "getVenueRatePlanList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        public async Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id)
        {
            return await this.CallAsync<Venue.Booking>(
                "venue", "getBooking", new {
                    venueId = venueId,
                    id = id
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.Bookings.Accommodation>>> GetVenueBookingAccommodationListAsync(
            int venueId,
            int bookingId)
        {
            return await this.CallAsync<ResultList<Venue.Bookings.Accommodation>>(
                "venue", "getBookingAccommodationList", new {
                    venueId = venueId,
                    bookingId = bookingId
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateVenueBookingAccommodationAsync(
            Venue.Bookings.Accommodation group)
        {
            // Null out the group properties that cannot be added/updated.
            group.CostCenterId = null;
            group.CreatedDate = null;
            group.ModifiedDate = null;
            if (group.DayRates != null) {
                foreach (var dayRate in group.DayRates) {
                    if (dayRate != null) {
                        dayRate.NumFreeRooms = null;
                    }
                }
            }
            if (group.RoomOptions != null) {
                foreach (var roomOpt in group.RoomOptions) {
                    if (roomOpt != null) {
                        roomOpt.TotalAmount = null;
                        roomOpt.TotalTaxAmount = null;
                    }
                }
            }

            return await this.CallAsync<ResultObject>(
                "venue", "addOrUpdateBookingAccommodation", group
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.RemoveBookingAccommodationResult>> RemoveVenueBookingAccommodationAsync(
            int venueId,
            int bookingId,
            int id)
        {
            return await this.CallAsync<Venue.Bookings.RemoveBookingAccommodationResult>(
                "venue", "removeBookingAccommodation", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    id = id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.Bookings.RoomReservation>>> GetVenueBookingRoomReservationListAsync(
            int venueId,
            int perPage,
            int start,
            int? bookingId,
            Dictionary<string, object> filterRequest)
        {
            return await this.CallAsync<ResultList<Venue.Bookings.RoomReservation>>(
                "venue", "getBookingRoomReservationList", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    start = start,
                    perPage = perPage,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.RoomReservation>> GetVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int reservationId)
        {
            var listResult = await this.GetVenueBookingRoomReservationListAsync(
                venueId, 1, 0, bookingId, new Dictionary<string, object>() {
                    { "id", reservationId }
                }
            );
            var newResult = new ResultOrError<Venue.Bookings.RoomReservation>() {
                ErrorCode = listResult.ErrorCode,
                ErrorCodeSpecific = listResult.ErrorCodeSpecific,
                ErrorMessage = listResult.ErrorMessage
            };
            if (listResult.IsSuccess()) {
                if (listResult.Result.Meta.Count == 1) {
                    newResult.Result = listResult.Result.Results[0];
                }
                else {
                    newResult.ErrorCode = LibErrorCode;
                    newResult.ErrorMessage = "The room reservation does not exist";
                }
            }
            return newResult;
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.AddUpdateBookingRoomReservationResult>> AddOrUpdateVenueBookingRoomReservationAsync(
            Venue.Bookings.RoomReservation reservation)
        {
            // Null out the reservation properties that cannot be added/updated.
            reservation.Reference = null;
            reservation.MainGuestId = null;
            if (reservation.MainGuest != null) {
                reservation.MainGuest.CreatedDate = null;
                reservation.MainGuest.ModifiedDate = null;
                if (reservation.MainGuest.Contact != null) {
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
            if (reservation.Rooms != null) {
                foreach (var room in reservation.Rooms) {
                    if (room == null) {
                        continue;
                    }
                    room.GuestId = null;
                    if (room.Guest != null) {
                        room.Guest.CreatedDate = null;
                        room.Guest.ModifiedDate = null;
                        if (room.Guest.Contact != null) {
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
                    if (room.DayRates != null) {
                        foreach (var rate in room.DayRates) {
                            if (rate == null) {
                                continue;
                            }
                            rate.RatePlanId = null;
                        }
                    }
                    if (room.AdditionalGuests != null) {
                        foreach (var additionalGuest in room.AdditionalGuests) {
                            if (additionalGuest == null) {
                                continue;
                            }
                            if (additionalGuest.Guest != null) {
                                additionalGuest.Guest.CreatedDate = null;
                                additionalGuest.Guest.ModifiedDate = null;
                                if (additionalGuest.Guest.Contact != null) {
                                    additionalGuest.Guest.Contact.CreatedDate = null;
                                    additionalGuest.Guest.Contact.ModifiedDate = null;
                                }
                            }
                        }
                    }
                }
            }

            return await this.CallAsync<Venue.Bookings.AddUpdateBookingRoomReservationResult>(
                "venue", "addOrUpdateBookingRoomReservation", reservation
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.RemoveBookingRoomReservationResult>> RemoveVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id)
        {
            return await this.CallAsync<Venue.Bookings.RemoveBookingRoomReservationResult>(
                "venue", "removeBookingRoomReservation", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    id = id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.ConfirmBookingRoomReservationResult>> ConfirmVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id)
        {
            return await this.CallAsync<Venue.Bookings.ConfirmBookingRoomReservationResult>(
                "venue", "confirmBookingRoomReservation", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    id = id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.CancelBookingRoomReservationResult>> CancelVenueBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id,
            int? roomId = null)
        {
            return await this.CallAsync<Venue.Bookings.CancelBookingRoomReservationResult>(
                "venue", "cancelBookingRoomReservation", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    id = id,
                    roomId = roomId,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Venue.Bookings.ChangeStatusOfBookingRoomReservationResult>> ChangeStatusOfBookingRoomReservationAsync(
            int venueId,
            int bookingId,
            int id,
            Venue.Bookings.RoomReservation.StatusOptions newStatus)
        {
            return await this.CallAsync<Venue.Bookings.ChangeStatusOfBookingRoomReservationResult>(
                "venue", "changeStatusOfBookingRoomReservation", new {
                    venueId = venueId,
                    bookingId = bookingId,
                    id = id,
                    status = newStatus,
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
            return await this.CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingList", new {
                    venueId = venueId,
                    perPage = perPage,
                    start = start,
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
            return await this.CallAsync<ResultList<Venue.Booking>>(
                "venue", "getBookingListForAccount", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCounts(
            int venueId,
            int roomId,
            string startDate,
            string endDate,
            int roomCount)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomCounts", new
                {
                    venueId = venueId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    roomCount = roomCount
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            double cost)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRoomDynamicRates", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    cost = cost
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
            return await this.CallAsync<ResultSuccess>(
                "venue", "removeRoomDynamicRates", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRules(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            Venue.RatePlan.CloseOutStatusOptions closeOutStatus)
        {
            return await this.CallAsync<ResultSuccess>(
                "venue", "addOrUpdateRatePlanBookingRules", new
                {
                    venueId = venueId,
                    barId = ratePlanId,
                    roomId = roomId,
                    startDate = startDate,
                    endDate = endDate,
                    closeOutStatus = closeOutStatus
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Venue.Tax>>> GetVenueTaxListAsync(int venueId)
        {
            return await this.CallAsync<ResultList<Venue.Tax>>(
                "venue", "getTaxList", new {
                    venueId = venueId,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Account.CostCenter>>> GetVenueCostCenterListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Account.CostCenter>>(
                "venue", "getCostCenterList", new {
                    venueId = venueId,
                    perPage = perPage,
                    start = start,
                }
            );
        }
    }
}