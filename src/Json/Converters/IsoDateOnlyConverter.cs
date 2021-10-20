using Newtonsoft.Json.Converters;

namespace Ivvy.API.Json.Converters
{
    public class IsoDateOnlyConverter : IsoDateTimeConverter
    {
        public IsoDateOnlyConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}