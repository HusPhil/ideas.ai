using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdeasAi.Gemini_AI
{
    internal class AppSettings
    {

        [JsonProperty("API_KEY")]
        public string ApiKey { get; set; }

        [JsonProperty("Python_Module")]
        public string PythonModule { get; set; }

        [JsonProperty("Database_Path")]
        public string DBPath { get; set; }
    }
}
