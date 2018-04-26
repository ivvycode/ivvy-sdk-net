
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
            NoMarketing=5
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
            Tentative=2,
            Confirmed=3,
            Cancelled=4,
            Ordering=5,
            NotAccepted=6
        }

        public enum FieldType {
            SmallText=0,
            LargeText=1,
            SingleSelect=2,
            MultipleSelect=3,
            Address=4,
            Date=5,
            File=6,
            StaticText=7,
            WholeNumber=8
        }
    }
}
