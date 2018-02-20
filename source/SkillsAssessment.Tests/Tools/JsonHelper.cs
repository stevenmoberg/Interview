using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests
{
    public static class JsonHelper
    {
        public static string ToJson(this object value, bool prettyPrint = false)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = prettyPrint ? Formatting.Indented : Formatting.None
                // DefaultValueHandling = DefaultValueHandling.Ignore;
                // NullValueHandling = NullValueHandling.Ignore;
            };

            return JsonConvert.SerializeObject(value, settings);
        }

        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
