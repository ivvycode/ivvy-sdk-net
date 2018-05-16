using System.Runtime.Serialization;

namespace Ivvy.API.Helper
{
    public class EnumHelper
    {
        public enum CurrentStatus
        {
            NotPaid = 0,
            UnConfirmedPaid = 1,
            Paid = 2,
            WrittenOff = 3,
            Cancelled = 4,
            Refunded = 5
        }

        public enum InvoiceRefType
        {
            Custom = 0,
            EventRegistration = 1,
            MembershipSignUp = 2,
            MembershipRenewal = 3,
            VenueBooking = 4
        }

        public enum EmailStatus
        {
            Subscribed = 1,
            Unsubscribed = 2,
            Bounced = 3,
            Registering = 4,
            NoMarketing = 5
        }

        public enum SmsStatus
        {
            Subscribed = 1,
            Unsubscribed = 2,
            Failed = 3,
            NoMarketing = 4,
        }

        public enum BookingStatus
        {
            Prospective = 1,
            Tentative = 2,
            Confirmed = 3,
            Cancelled = 4,
            Ordering = 5,
            NotAccepted = 6
        }

        public enum FieldType
        {
            SmallText = 0,
            LargeText = 1,
            SingleSelect = 2,
            MultipleSelect = 3,
            Address = 4,
            Date = 5,
            File = 6,
            StaticText = 7,
            WholeNumber = 8
        }

        public enum FilterCondition
        {
            //Return the results that contain the value.
            Contains​,
            //Return the results that do not contain the value.
            Notcontains​,
            //Return the results that start with the value.
            Begins​,
            //Return the results that end with the value.
            Ends​,
            //Return the results that are less than or equal to the value.
            Lessthan​,
            //Return the results that are greater than or equal to the
            Greaterthan​,
            //Return the results that are not equal to the value.
            Not​,
            //Returns results that are empty
            Empty​
        }

        public enum EventTypes
        {
            Other = 0,
            Party = 1,
            Festival = 2,
            GolfDay = 3,
            Wedding = 4,
            Meeting = 5,
            Seminar = 6,
            Conference = 7,
            Exhibition = 8,
            Roadshow = 9,
            Simple = 10,
            Party18or21 = 11,
        }

        public enum EventStatusTypes
        {
            Draft = 0,
            Closed = 1,
            Launched = 3,
        }

        public enum EmailRefType
        {
            Other = 0,
            Contact = 1,
            Event = 2,
            Membership = 3,
            Abstract = 4,
            Registration = 5,
            Invoice = 6,
            Author = 7,
            Task = 8,

            [EnumMember(Value = "Credit Note")]
            CreditNote = 9,

            Survey = 10,

            [EnumMember(Value = "Venue Marketplace")]
            VenueMarketplace = 11,

            Booking = 12,
            Company = 13,

            [EnumMember(Value = "Floor Plan")]
            FloorPlan = 14
        }

        public enum EmailType
        {
            Unknown = 0,

            [EnumMember(Value = "Completed Event Registration")]
            CompletedEventRegistration = 1,

            [EnumMember(Value = "Completed Event Registration (Waiting on Payment)")]
            CompletedEventRegistrationWaitingonPayment = 2,

            [EnumMember(Value = "Accommodation Confirmation")]
            AccommodationConfirmation = 3,

            [EnumMember(Value = "Travel Confirmation")]
            TravelConfirmation = 4,

            [EnumMember(Value = "Registration Payment Reminder")]
            RegistrationPaymentReminder = 5,

            [EnumMember(Value = "Exhibitor Final Confirmation")]
            ExhibitorFinalConfirmation = 8,

            [EnumMember(Value = "Abstract/Paper Submission Created")]
            AbstractOrPaperSubmissionCreated = 11,

            [EnumMember(Value = "Abstract/Paper Changes Requested")]
            AbstractOrPaperChangesRequested = 12,

            [EnumMember(Value = "Abstract/Paper Submission Rejected")]
            AbstractOrPaperSubmissionRejected = 13,

            [EnumMember(Value = "Abstract/Paper Submission Accepted")]
            AbstractOrPaperSubmissionAccepted = 14,

            [EnumMember(Value = "Abstract/Paper Reviewer Added")]
            AbstractOrPaperReviewerAdded = 15,

            [EnumMember(Value = "Contact Changed")]
            ContactChanged = 16,

            [EnumMember(Value = "Hotel Changed")]
            HotelChanged = 17,

            [EnumMember(Value = "Flight Changed")]
            FlightChanged = 18,

            [EnumMember(Value = "Tickets Changed")]
            TicketsChanged = 19,

            [EnumMember(Value = "Exhibitor Confirmation")]
            ExhibitorConfirmation = 20,

            [EnumMember(Value = "Session Confirmation")]
            SessionConfirmation = 21,

            [EnumMember(Value = "Session Changed")]
            SessionChanged = 22,

            [EnumMember(Value = "Abstract Changed")]
            AbstractChanged = 23,

            [EnumMember(Value = "Final Confirmation")]
            FinalConfirmation = 24,

            [EnumMember(Value = "Event Feedback")]
            EventFeedback = 30,

            [EnumMember(Value = "Event Reminder")]
            EventReminder = 31,

            Abstract = 26,

            [EnumMember(Value = "API Leadtracker")]
            ApiLeadtracker = 27,

            [EnumMember(Value = "Contact Subscribed")]
            ContactSubscribed = 28,

            [EnumMember(Value = "Transfer Changed")]
            TransferChanged = 29,

            [EnumMember(Value = "Password Reset")]
            PasswordReset = 1000,

            Notification = 1001,
            Task = 1002,
            Statement = 1500,
            Invoice = 1501,

            [EnumMember(Value = "Credit Note")]
            CreditNote = 1502,

            [EnumMember(Value = "Membership Signup")]
            MembershipSignup = 2000,

            [EnumMember(Value = "Membership Renewal")]
            MembershipRenewal = 2001,

            [EnumMember(Value = "Renewal Notice")]
            RenewalNotice = 2002,

            Survey = 3000,

            [EnumMember(Value = "New Company Added")]
            NewCompanyAdded = 1003,

            [EnumMember(Value = "Venue Booking Document")]
            VenueBookingDocument = 4000,

            [EnumMember(Value = "Venue Booking Floor Plan")]
            VenueBookingFloorPlan = 4001,

            [EnumMember(Value = "Incomplete Registration")]
            IncompleteRegistration = 32
        }
    }
}
