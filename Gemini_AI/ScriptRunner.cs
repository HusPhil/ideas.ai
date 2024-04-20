﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IdeasAi.Gemini_AI
{
    internal class ScriptRunner
    {
        
        public static string runScript(string scriptName, string prompt)
        {
            string jsonString = File.ReadAllText("configs/settings.json");

            var appSettings = JObject.Parse(jsonString);
            ReplaceEnvironmentVariables(appSettings);

            var pythonModule = (string)appSettings["Python_Module"];
            var apiKey = (string)appSettings["API_KEY"];

            var psi = new ProcessStartInfo();
            psi.FileName = pythonModule;
            psi.Arguments = $"\"{scriptName}\" \"{prompt.Replace("\"", "'")}\" \"{apiKey}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            var result = "ERROR";
            var error = "NONE";
            Console.WriteLine(prompt);
            using (var process = Process.Start(psi))
            {
                result = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
                
            }
            Console.WriteLine("result: " + result);
            //Console.WriteLine(error);

            

            return result;



        }

        public static async Task<string> RunScriptAsync(string scriptName, string prompt, JObject appConfig)
        {
            

            ReplaceEnvironmentVariables(appConfig);

            var pythonModule = (string)appConfig["Python_Module"];
            var apiKey = (string)appConfig["API_KEY"];

            Console.WriteLine(pythonModule + "::" + apiKey);

            var psi = new ProcessStartInfo();
            psi.FileName = pythonModule;
            psi.Arguments = $"\"{scriptName}\" \"{prompt}\" \"{apiKey}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            var result = "";
            var error = "";
            Console.WriteLine(prompt);
            using (var process = Process.Start(psi))
            {
                result = await process.StandardOutput.ReadToEndAsync();
                error = await process.StandardError.ReadToEndAsync();
            }
            Console.WriteLine(error);

            return result;
        }

        public static void ReplaceEnvironmentVariables(JObject config)
        {
            foreach (JProperty property in config.Properties())
            {
                if (property.Value.Type == JTokenType.String && property.Value.ToString().StartsWith("__") && property.Value.ToString().EndsWith("__"))
                {
                    string envVarName = property.Value.ToString().Trim('_');
                    string envVarValue = Environment.GetEnvironmentVariable(envVarName) ?? string.Empty;
                    property.Value = envVarValue;
                }
            }
        }
    }

}
