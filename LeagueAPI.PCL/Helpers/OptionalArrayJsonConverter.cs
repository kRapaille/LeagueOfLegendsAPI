using System;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Helpers
{
    class OptionalArrayJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            float[] result = null;

            if (reader.ValueType == typeof(float))
            {
                result = new[] { (float)reader.Value };   
            }
            else if (reader.ValueType == typeof(double))
            {
                result = new[] { (float)((double)reader.Value) };
            }

            return result ?? reader.Value;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
