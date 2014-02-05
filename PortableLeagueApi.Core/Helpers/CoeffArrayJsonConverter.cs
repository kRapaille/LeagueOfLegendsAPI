using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Core.Helpers
{
    public class CoeffArrayJsonConverter : JsonConverter
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
            else if (reader.ValueType == null)
            {
                var values = new List<float>();

                while (reader.Read())
                {
                    var value = 0.0f;

                    if (reader.ValueType == typeof(float))
                    {
                        value = (float)reader.Value;
                    }
                    else if (reader.ValueType == typeof(double))
                    {
                        value = (float)((double)reader.Value);
                    }

                    values.Add(value);

                    if(reader.TokenType == JsonToken.EndArray)
                        break;
                }

                result = values.ToArray();
            }
            
            return result ?? reader.Value;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
