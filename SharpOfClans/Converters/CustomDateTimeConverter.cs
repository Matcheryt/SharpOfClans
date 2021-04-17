using Newtonsoft.Json.Converters;

namespace SharpOfClans.Converters
{
    /// <summary>
    /// Class which specifies the date time format to use in conversion.
    /// </summary>
    internal class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            DateTimeFormat = "yyyyMMddTHHmmss.FFFK";
        }
    }
}
