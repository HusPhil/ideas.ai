using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    internal class IdeaOrganizer : AI_Response
    {
        public string Title { get; set; }
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Organize, elaborate, and expand the inputted idea, with correct grammar and format of sentences." +
                "If the input is not substantial or does not make sense for a scratch of an idea, tell the user to try again." +
                $"The input supplied: {this.Input.Replace("\"", "'")}.";

            string response = await ScriptRunner.RunScriptAsync("Gemini_AI\\Scripts\\gemini.py", prompt, appConfig);
            this.DateCreated = DateTime.Now;
            if (response.Contains("ERROR"))
            {
                throw new Exception(response);
            }
            return response;
        }
    }
}
