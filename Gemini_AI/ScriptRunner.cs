using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdeasAi.Gemini_AI
{
    internal class ScriptRunner
    {
        public static string runScript(string scriptName, string prompt)
        {
            string jsonString = File.ReadAllText("settings.json");

            var appSettings = JsonConvert.DeserializeObject<AppSettings>(jsonString);
            var pythonModule = appSettings.PythonModule;
            var apiKey = appSettings.ApiKey;

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

        public static async Task<string> RunScriptAsync(string scriptName, string prompt)
        {
            string jsonString = File.ReadAllText("settings.json");

            var appSettings = JsonConvert.DeserializeObject<AppSettings>(jsonString);
            var pythonModule = appSettings.PythonModule;
            var apiKey = appSettings.ApiKey;

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
    }
}
