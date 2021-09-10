using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class CostCenter : Account.CostCenter
    {
        [JsonProperty("parentId")]
        public int? ParentId
        {
            get; set;
        }
    }
}