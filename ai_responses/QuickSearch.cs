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
            var prompt = "Pretend you are an expert, your job is to talk in a human like convesational tone and " +
                "answer the question in a concise and brief way. You use simple lanaguage in explaining things and" +
                " you provide summary for all information that you have given. " + 
                "Don't supply information that may overwhelm the reader." +
                $"The question supplied: {this.Input.Replace("\"", "'")}.";

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
