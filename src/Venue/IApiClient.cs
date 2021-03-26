using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Venue;
using Ivvy.API.Venue.ARI;
using Ivvy.API.Venue.Bookings;

namespace Ivvy.API
{
    public partial interface IApiClient
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Venue.Venue>> GetVenueAsync(int id);

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a collection of venue accommodation rooms options.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.RoomOption>>> GetVenueRoomOptionListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id);

        /// <summary>
        /// Adds or updates a booking.
        /// <param name="reservation">Details of the booking</param>
        /// </summary>
        Task<ResultOrError<AddUpdateBookingResult>> AddOrUpdateVenueBookingAsync(Venue.Booking booking);

        /// <summary>
        /// Returns a collection of booking accommodation groups in an iVvy venue booking.
        /// </summary>
        /// <param name="venueId">The unique id of the venue to which the bookings belong</param>
        /// <param name="bookingId">The unique id of the booking to which the accommodation belongs</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Accommodation>>> GetVenueBookingAccommodationListAsync(
            int venueId, int bookingId
        );

        /// <summary>
        /// Returns a collection of booking notes in an iVvy venue booking.
        /// </summary>
        /// <param name="venueId">The unique id of the venue to which the notes belong</param>
        /// <param name="bookingId">The unique id of the boking to which the notes belong</param>
        /// <param name="perPage">The number of booking notes to fetch with a single API call</param>
        /// <param name="start">The starting result of the page. Note this is zero based.</param>
        /// <param name="filterRequest">A dictionary of additional filter properties.</param>
        /// <returns>Collection of booking notes in an iVvy venue booking.</returns>
        Task<ResultOrError<ResultList<Venue.Note>>> GetVenueBookingNoteListAsync(
            int venueId,
            int bookingId,
            int perPage,
            int start,
            Dictionary<string, object> filterRequest);

        /// <summary>
        /// Adds or updates venue booking accommodation.
        /// <param name="group">Details of the venue booking accommodation</param>
        /// </summary>
        Task<ResultOrError<ResultObject>> AddOrUpdateVenueBookingAccommodationAsync(Accommodation group);

        /// <summary>
        /// Removes a specific accommodation group from a venue booking.
        /// <param name="venueId">The unique id of the venue to which the booking belongs</param>
        /// <param name="bookingId">The unique id of the booking to which the accommodation belongs</param>
        /// <param name="id">The unique id of the accommodation group to remove from the booking</param>
        /// </summary>
        Task<ResultOrError<RemoveBookingAccommodationResult>> RemoveVenueBookingAccommodationAsync(
            int venueId, int bookingId, int id
        );

        /// <summary>
        /// Returns a collection of booking room reservations in an iVvy venue.
        /// </summary>
        /// <param name="venueId">The unique id of the venue to which the bookings belongs</param>
        /// <param name="perPage">The number of booking room reservations to fetch</param>
        /// <param name="start">The starting result of the page. Note this is zero based (i.e. sending start=0 will start from the first result.)</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservations belong</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<RoomReservation>>> GetVenueBookingRoomReservationListAsync(
            int venueId, int perPage, int start, int? bookingId, Dictionary<string, object> filterRequest
        );

        /// <summary>
        /// Returns a room reservation in an iVvy venue booking.
        /// </summary>
        /// <param name="venueId">The unique id of the venue to which the bookings belong</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservation belongs</param>
        /// <param name="reservationId">The unique id of the room reservation</param>
        /// <returns></returns>
        Task<ResultOrError<RoomReservation>> GetVenueBookingRoomReservationAsync(
            int venueId, int bookingId, int reservationId
        );

        /// <summary>
        /// Adds or updates a booking room reservation.
        /// <param name="reservation">Details of the booking room reservation</param>
        /// </summary>
        Task<ResultOrError<AddUpdateBookingRoomReservationResult>> AddOrUpdateVenueBookingRoomReservationAsync(RoomReservation reservation);

        /// <summary>
        /// Removes a specific room reservation from a venue booking.
        /// <param name="venueId">The unique id of the venue to which the booking belongs</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservation belongs</param>
        /// <param name="id">The unique id of the room reservation to remove from the booking</param>
        /// </summary>
        Task<ResultOrError<RemoveBookingRoomReservationResult>> RemoveVenueBookingRoomReservationAsync(
            int venueId, int bookingId, int id
        );

        /// <summary>
        /// Confirms a specific room reservation from a venue booking.
        /// <param name="venueId">The unique id of the venue to which the booking belongs</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservation belongs</param>
        /// <param name="id">The unique id of the room reservation to confirm</param>
        /// <param name="roomIds">Optional parameter. The unique ids of the rooms to confirm</param>
        /// </summary>
        Task<ResultOrError<ConfirmBookingRoomReservationResult>> ConfirmVenueBookingRoomReservationAsync(
            int venueId, int bookingId, int id, int[] roomIds = null);

        /// <summary>
        /// Cancels a specific room reservation from a venue booking.
        /// <param name="venueId">The unique id of the venue to which the booking belongs</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservation belongs</param>
        /// <param name="id">The unique id of the room reservation to cancel</param>
        /// <param name="roomId">Optionally cancel a single room on the reservation.</param>
        /// </summary>
        Task<ResultOrError<CancelBookingRoomReservationResult>> CancelVenueBookingRoomReservationAsync(
            int venueId, int bookingId, int id, int? roomId = null
        );

        /// <summary>
        /// Changes the status of a specific room reservation in a venue booking.
        /// <param name="venueId">The unique id of the venue to which the booking belongs</param>
        /// <param name="bookingId">The unique id of the booking to which the room reservation belongs</param>
        /// <param name="id">The unique id of the room reservation to change status</param>
        /// <param name="newStatus">The status to which the room reservation will be changed</param>
        /// <param name="roomIds">Optional parameter. The unique ids of the rooms to change status</param>
        /// </summary>
        Task<ResultOrError<ChangeStatusOfBookingRoomReservationResult>> ChangeStatusOfBookingRoomReservationAsync(
            int venueId, int bookingId, int id, RoomReservation.StatusOptions newStatus, int[] roomIds = null
        );

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy venue.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListAsync(
            int venueId, int perPage, int start, Dictionary<string, object> filterRequest);

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListForAccountAsync(
            int perPage, int start, Dictionary<string, object> filterRequest);

        /// <summary>
        /// Add or updates the dynamic inventory counts of a specific venue room.
        /// <param name="venueId">The unique id of the venue to which the room belongs</param>
        /// <param name="roomId">The unique id of the room for which the inventory count will be set</param>
        /// <param name="startDate">The start date from which the room inventory count will be set (Date Format)</param>
        /// <param name="endDate">The end date from which the room inventory count will be set (Date Format)</param>
        /// <param name="roomCount">The inventory count of the room from startDate to endDate</param>
        /// </summary>
        [Obsolete("Use AddOrUpdateVenueRoomCountsCollection() instead")]
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCounts(
            int venueId,
            int roomId,
            string startDate,
            string endDate,
            int roomCount);

        /// <summary>
        /// Adds/updates a collection of dynamic inventory counts of a venue.
        /// <param name="venueId">The unique id of the venue to which the inventory counts belong</param>
        /// <param name="items">The collection of room inventory counts</param>
        /// </summary>
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomCountsCollection(
            int venueId,
            List<RoomCount> items);

        /// <summary>
        /// Add or update the dynamic rates of a specific venue room.
        /// <param name="venueId">The unique id of the venue to which the rate plan belongs</param>
        /// <param name="ratePlanId">The unique id of the rate plan to which the dynamic rate applies</param>
        /// <param name="roomId">The unique id of the room to which the rate applies</param>
        /// <param name="startDate">The start date from which the dynamic rate will be set (Date Format)</param>
        /// <param name="endDate">The end date from which the dynamic rate will be set (Date Format)</param>
        /// <param name="cost">The rate amount from startDate to endDate. The amount must either include or exclude tax depending on how the venue has been configured</param>
        /// </summary>
        [Obsolete("Use AddOrUpdateVenueRoomDynamicRatesCollection() instead")]
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            double cost);

        /// <summary>
        /// Adds/updates a collection of dynamic room rates of a venue rate plan.
        /// <param name="venueId">The unique id of the venue to which the dynamic room rates belong</param>
        /// <param name="items">The collection of rate plan room rates</param>
        /// </summary>
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRoomDynamicRatesCollection(
            int venueId,
            List<RatePlanRoomRate> items);

        /// <summary>
        /// Remove one or more dynamic rates from a specific venue room.
        /// <param name="venueId">The unique id of the venue to which the rate plan belongs</param>
        /// <param name="ratePlanId">The unique id of the rate plan to which the dynamic rate applies</param>
        /// <param name="roomId">The unique id of the room to which the rate applies</param>
        /// <param name="startDate">The start date from which the dynamic rate will be removed (Date Format)</param>
        /// <param name="endDate">The end date until which the dynamic rate will be removed (Date Format)</param>
        /// </summary>
        Task<ResultOrError<ResultSuccess>> RemoveVenueRoomDynamicRates(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate);

        /// <summary>
        /// Add or update the booking rules of a specific rate plan and room.
        /// <param name="venueId">The unique id of the venue to which the rate plan belongs</param>
        /// <param name="ratePlanId">The unique id of the rate plan to which the booking rule applies</param>
        /// <param name="roomId">The unique id of the room to which the booking rule applies</param>
        /// <param name="startDate">The start date from which the booking rule will apply (Date Format)</param>
        /// <param name="endDate">The end date until which the booking rule will apply (Date Format)</param>
        /// <param name="closeOutStatus">The close out status of the booking rule from startDate to endDate</param>
        /// </summary>
        [Obsolete("Use AddOrUpdateVenueRatePlanRulesCollection() instead")]
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRules(
            int venueId,
            int ratePlanId,
            int roomId,
            string startDate,
            string endDate,
            Venue.RatePlan.CloseOutStatusOptions closeOutStatus);

        /// <summary>
        /// Adds/updates a collection of booking rules of a venue rate plan.
        /// <param name="venueId">The unique id of the venue to which the booking rules belong</param>
        /// <param name="items">The collection of rate plan booking rules</param>
        /// </summary>
        Task<ResultOrError<ResultSuccess>> AddOrUpdateVenueRatePlanRulesCollection(
            int venueId,
            List<RatePlanBookingRule> items);

        /// <summary>
        /// Returns a collection of venue taxes in an iVvy account.
        /// <param name="venueId">The unique id of the venue to which the taxes belong</param>
        /// </summary>
        Task<ResultOrError<ResultList<Venue.Tax>>> GetVenueTaxListAsync(int venueId);

        /// <summary>
        /// Returns a collection of cost centers that belong to an iVvy venue.
        /// </summary>
        /// <param name="venueId">The unique id of the venue to which the cost centers belong</param>
        /// <param name="perPage">The number of cost centers to fetch</param>
        /// <param name="start">The starting result of the page. Note this is zero based (i.e. sending start=0 will start from the first result.)</param>
        Task<ResultOrError<ResultList<Venue.CostCenter>>> GetVenueCostCenterListAsync(
            int venueId,
            int perPage,
            int start);

        /// <summary>
        /// Changes the status of a given booking.
        /// </summary>
        /// <param name="request">The request that contains the booking status change details.</param>
        Task<ResultOrError<ResultObject>> ChangeBookingStatusAsync(
            ChangeBookingStatusRequest request);
    }
}
