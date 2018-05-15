using Ivvy.Json;
using System;

namespace Ivvy.Booking
{
    public class Booking : ISerializable
    {
        public int id { get; set; }
        public int venueId { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Company company { get; set; }
        public Ivvy.Contact.Contact contact { get; set; }
        public Nullable<int> currentStatus { get; set; }
        public int totalAmount { get; set; }
        public decimal totalTaxAmount { get; set; }
        public long amountOutstanding { get; set; }
        public object accountTimezone { get; set; }
        public object venueTimezone { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public DateTime dateEventStart { get; set; }
        public DateTime dateEventEnd { get; set; }
        public bool isAccommIncluded { get; set; }
        public string dateAccomStart { get; set; }
        public string dateAccomEnd { get; set; }
        public bool hasPackages { get; set; }
        public string decisionDate { get; set; }
        public bool isBeoFinalised { get; set; }
        public string beoFinalisedDate { get; set; }
        public string eventType { get; set; }
    }
}
