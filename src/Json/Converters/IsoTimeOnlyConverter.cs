using Newtonsoft.Json.Converters;

namespace Ivvy.API.Json.Converters
{
    public class IsoTimeOnlyConverter : IsoDateTimeConverter
    {
        public IsoTimeOnlyConverter()
        {
            base.DateTimeFormat = "HH:mm:ss";
        }
    }
}