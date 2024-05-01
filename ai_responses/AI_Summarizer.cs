using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    internal class AI_Summarizer : AI_Response
    {
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Act as an expert summarizer. " +
                "Summarize the text that will be suppplied." +
                "Write it using simple words in a conversational tone." +
                "Make sure to not modify the context and also do not remove important details from the text." +
                "Write in paragraph form." +
                $"The text supplied: {this.Input.Replace("\"", "'")}.";

            string response = await ScriptRunner.RunScriptAsync("Gemini_AI\\Scripts\\gemini.py", prompt, appConfig);
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
