using System;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy note.
    /// </summary>
    public class Note
    {
        public enum NoteType
        {
            LeadOriginal = -1,
            NoType = 0,
            Booking = 1,
            Session = 2,
            Billing = 3,
            SessionMenu = 4,
            SessionBeverage = 5,
            SessionResourses = 6,
            SessionProducts = 7,
            Accommodation = 8,
            Contact = 9,
            Company = 10,
            Couriers = 11,
            VipGuests = 12,
            Security = 13,
            OnSideContractors = 14,
            Signatories = 15,
            FrontOffices = 16,
            Transfers = 17,
            RoomDrops = 18,
            LuggageServices = 19,
            GroupProfile = 20,
            Lead = 21,
            DietaryRequirements = 22,
            AllDepartments = 23,
            FoodAndBeverage = 24,
            CarParking = 25,
            Suppliers = 26,
            Internet = 27,
            LeadDescription = 28,
            Signage = 29,
            SalesOffice = 30,
            BellmanVanService = 31,
            Reservation = 32,
            Housekeeping = 33,
            Engineering = 34
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("bookingId")]
        public int BookingId
        {
            get; set;
        }

        [JsonProperty("isPrivate")]
        public bool IsPrivate
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("typeId")]
        public NoteType Type
        {
            get; set;
        }

        [JsonProperty("createdBy")]
        public int? CreatorId
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
        {
            get; set;
        }
    }
}