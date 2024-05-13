using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    public class AI_Elaborator : AI_Response
    {
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Expand my ideas. " +
                $"The context supplied: {this.Input.Replace("\"", "'")}.";

            string response = await ScriptRunner.GetResponseAsync(prompt);
            this.DateCreated = DateTime.Now;
            Console.WriteLine(response);
            if (response.Contains("ERROR"))
            {
                throw new Exception(response);
            }

            return response;
        }
    }
}
