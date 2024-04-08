using IdeasAi.Gemini_AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    public class QuickSearch : AI_Response
    {
        public override async Task<string> GetResponse()
        {
            var prompt = "Provide very brief useful explanation about the input that can be understood in simple words. " +
                "Provide concise summary at the end. Format it in readable and organize way. " +
                "Just give the answer, dont mention the input." +
                "Don't supply information that may overwhelm the reader." +
                $"The topic supplied: {this.Input.Replace("\"", "'")}.";

            string response = await ScriptRunner.RunScriptAsync("Gemini_AI\\Scripts\\gemini.py", prompt);
            this.DateCreated = DateTime.Now;
            if (response.Contains("ERROR"))
            {
                throw new Exception(response);

            }
            return response;
        }

    }
}
