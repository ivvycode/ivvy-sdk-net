using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// Encapsulates the details of how an opportunity should be allocated
    /// based on the online booking rules of a venue.
    /// </summary>
    public class HowToAllocateOpportunity
    {
        public enum OpportunityTypes
        {
            EventOnly = 1,
            AccommodationOnly = 2,
            EventAndAccommodation = 3,
        }

        [JsonProperty("users")]
        public AllocateToUser[] Users
        {
            get; set;
        }

        [JsonProperty("additionalEmails")]
        public string[] AdditionalEmails
        {
            get; set;
        }
    }
}