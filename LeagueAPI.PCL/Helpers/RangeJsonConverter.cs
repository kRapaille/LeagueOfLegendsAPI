using System;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Helpers
{
    internal class RangeJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var result = 0;

            if (reader.ValueType == typeof(string))
            {
                result = 0;
            }
            else if (reader.ValueType == null)
            {
                reader.Read();
                result = (int)((Int64)reader.Value);
                reader.Read();
            }

            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}
