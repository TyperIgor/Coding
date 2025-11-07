using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SolutionJSonTest
{
    public class GetJSonFromSTDIN
    {
        public static JsonAttributeEntity[] ParseTheJson(string parsedJson)
        {
            var deserialized = JsonSerializer.Deserialize<JsonAttributeEntity[]>(parsedJson);

            return deserialized;
        }
    }


    public class JsonAttributeEntity
    {
        public int RunId { get; set; }

        public string testName { get; set; }

        public string Login;

        public string status { get; set; }

        public int durationMs { get; set; }
    }
}
