namespace Ivvy.Event
{
    /// <summary>
    /// This class encapsulates the optional params that can be
    /// sent to the "getEventList" api method.
    /// </summary>
    public sealed class GetEventListOptions
    {
        public bool IncludeVenueDetails { get; set; }
        public bool IncludeTicketDetails { get; set; }
        public bool IncludeInformationDetails { get; set; }
        public bool IncludeHomePageContent { get; set; }
    }
}
