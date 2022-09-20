using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class AddUpdateNoteRequest
    {
        public enum TemplateTypeOptions
        {
            Beo = 1,
            QuotesAndContracts = 2,
            Resume = 3
        }

        [JsonProperty("id")]
        public int? Id
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
        public Note.NoteType? Type
        {
            get; set;
        }

        [JsonProperty("bookingDays")]
        public int[] BookingDays
        {
            get; set;
        }

        [JsonProperty("accommodationIds")]
        public int[] AccommodationIds
        {
            get; set;
        }

        [JsonProperty("sessionIds")]
        public int[] SessionIds
        {
            get; set;
        }

        [JsonProperty("menuIds")]
        public int[] MenuIds
        {
            get; set;
        }

        [JsonProperty("beverageIds")]
        public int[] BeverageIds
        {
            get; set;
        }

        [JsonProperty("resourceIds")]
        public int[] ResourceIds
        {
            get; set;
        }

        [JsonProperty("productIds")]
        public int[] ProductIds
        {
            get; set;
        }

        [JsonProperty("applyToTemplates")]
        public TemplateTypeOptions[] ApplyToTemplates
        {
            get; set;
        }
    }
}
