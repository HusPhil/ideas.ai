﻿using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.ai_responses
{
    public class AI_GrammarChecker : AI_Response
    {
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Check and improve the grammar. " +
                $"The context supplied: {this.Input.Replace("\"", "'")}.";

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
