using Newtonsoft.Json;
using System;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy note.
    /// </summary>
    public class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("venueId")]
        public int VenueId { get; set; }

        [JsonProperty("bookingId")]
        public int BookingId { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("typeId")]
        public NoteType Type { get; set; }

        [JsonProperty("createdBy")]
        public int CreatorId { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate { get; set; }

        public enum NoteType
        {
            LeadOriginal = -1,
            NoType,
            Booking,
            Session,
            Billing,
            SessionMenu,
            SessionBeverage,
            SessionResourses,
            SessionProducts,
            Accommodation,
            Contact,
            Company,
            Couriers,
            VipGuests,
            Security,
            OnSideContractors,
            Signatories,
            FrontOffices,
            Transfers,
            RoomDrops,
            LuggageServices,
            GroupProfile,
            Lead,
            DietaryRequirements,
            AllDepartments,
            FoodAndBeverage,
            CarParking,
            Suppliers,
            Internet,
            LeadDescription,
            Signage,
            SalesOffice,
            BellmanVanService,
            Reservation,
            Housekeeping,
            Engineering
        }
    }
}
