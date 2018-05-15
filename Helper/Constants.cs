namespace Ivvy.API.Helper
{
    public static class Constants
    {
        #region API namespaces

        public const string ContactApiNamespace = "contact";
        public const string VenueApiNamespace = "venue";
        public const string AccountApiNamespace = "account";
        public const string EventApiNamespace = "event";
        public const string InvoiceApiNampespace = "invoice";
        public const string TestApiNamespace = "test";

        #endregion

        #region API Actions

        public const string GetContactAction = "getContact";
        public const string GetContactListAction = "getContactList";
        public const string AddOrUpdateContactAction = "addOrUpdateContact";
        public const string GetCompanyAction = "getCompany";
        public const string GetCustomFieldAction = "getCustomFieldDefinition";
        public const string GetEmailLogListAction = "getEmailLogList";
        public const string GetEventAction = "getEvent";
        public const string GetEventListAction = "getEventList";
        public const string GetEventAttendeeListAction = "getAttendeeList";
        public const string GetEventRegistrationListAction = "getRegistrationList";
        public const string GetInvoiceAction = "getInvoice";
        public const string GetInvoiceListAction = "getInvoiceList";
        public const string GetBookingListAction = "getBookingList";
        public const string GetBookingAction = "getBooking";
        public const string GetSubscriptionGroupListAction = "getSubscriptionGroupList";
        public const string PingAction = "ping";

        #endregion
    }
}
