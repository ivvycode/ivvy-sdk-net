using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue function space.
    /// </summary>
    public class FunctionSpace : ISerializable
    {
        // Note that the available attributes in the SimpleLayoutType are different depending
        // on whether the function space has been retrieved via GetVenueDetails or via
        // GetFunctionSpaceList.
        public class SimpleLayoutType
        {
            [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Id
            {
                get; set;
            }
            [JsonProperty("layoutName")]
            public string LayoutName
            {
                get; set;
            }
            [JsonProperty("type")]
            public int? Type
            {
                get; set;
            }
            [JsonProperty("paxMinimum")]
            public int? PaxMinimum
            {
                get; set;
            }
            [JsonProperty("paxMaximum")]
            public int? PaxMaximum
            {
                get; set;
            }
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

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("categoryId")]
        public int? CategoryId
        {
            get; set;
        }

        [JsonProperty("imageId")]
        public int? ImageId
        {
            get; set;
        }

        [JsonProperty("hasLayouts")]
        public bool HasLayouts
        {
            get; set;
        }

        [JsonProperty("minPax")]
        public int? MinPax
        {
            get; set;
        }

        [JsonProperty("maxPax")]
        public int? MaxPax
        {
            get; set;
        }

        [JsonProperty("maxNumBookings")]
        public int? MaxNumBookings
        {
            get; set;
        }

        [JsonProperty("area")]
        public float? Area
        {
            get; set;
        }

        [JsonProperty("length")]
        public float? Length
        {
            get; set;
        }

        [JsonProperty("width")]
        public float? Width
        {
            get; set;
        }

        [JsonProperty("heightMaximum")]
        public float? HeightMaximum
        {
            get; set;
        }

        [JsonProperty("heightMinimum")]
        public float? HeightMinimum
        {
            get; set;
        }

        [JsonProperty("floorPressureMaximum")]
        public float? FloorPressureMaximum
        {
            get; set;
        }

        [JsonProperty("partSpaceIds")]
        public int[] PartSpaceIds
        {
            get; set;
        }

        [JsonProperty("includedInReportDashboard")]
        public bool IncludedInReportDashboard
        {
            get; set;
        }

        [JsonProperty("threeDScanId")]
        public string ThreeDScanId
        {
            get; set;
        }

        [JsonProperty("isViewable")]
        public bool IsViewable
        {
            get; set;
        }

        [JsonProperty("marketplaceName")]
        public string MarketplaceName
        {
            get; set;
        }

        [JsonProperty("eventTypes")]
        public int[] EventTypes
        {
            get; set;
        }

        [JsonProperty("sortOrder")]
        public int? SortOrder
        {
            get; set;
        }

        [JsonProperty("marketplaceSortOrder")]
        public int? MarketplaceSortOrder
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

        [JsonProperty("layouts")]
        public SimpleLayoutType[] Layouts
        {
            get; set;
        }
    }
}