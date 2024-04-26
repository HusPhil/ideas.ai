using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    internal class AI_Mindmap : AI_Response
    {
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Act like an automatic system text generator for a mindmap that follows a strict syntax. " +
                "Given an input, your goal is to organize an output based on the instructions given: " +
                "Expand the topic supplied and its subtopic then and generate a text about them for copy pasting. " +
                "The syntax for creating a mind map involves starting with @startmindmap and ending with @endmindmap. " +
                "Within this structure, asterisks (*) denote main topics or branches, double asterisks (**) represent sub-topics or sub-branches, " +
                "and triple asterisks (***) signify further sub-levels or details under each sub-topic. " +
                "Do not use any other characters beside asterisk because it would crash the system." +
                @"THIS IS THE SYNTAX YOU WILL FOLLOW IN GENERATING TEXT:
                @startmindmap
                * Main Topic
                ** Subtopic 1
                *** Details 1.1
                *** Details 1.2
                ** Subtopic 2
                *** Details 2.1
                **** Additional Details 2.1.1
                @endmindmap
                " +
                "Do not put '*' on @startmindmap and @endmindmap" +
                "There is always a space between * and the topics. " +
                "Follow the sytax strictly or the system will crash. " +
                "Most importantly, never use indentation." +
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
