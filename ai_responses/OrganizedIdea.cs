using IdeasAi.Gemini_AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    internal class OrganizedIdea : AI_Response
    {
        public string Title { get; set; }
        public override async Task<string> GetResponse()
        {
            var prompt = "Organize, elaborate, and expand the inputted idea, with correct grammar and format of sentences." +
                "If the input is not substantial or does not make sense for a scratch of an idea, tell the user to try again." +
                $"The input supplied: {this.Input}.";

            string response = await ScriptRunner.RunScriptAsync("Gemini_AI\\Scripts\\gemini.py", prompt);
            this.DateCreated = DateTime.Now;

            return response;
        }
    }
}
