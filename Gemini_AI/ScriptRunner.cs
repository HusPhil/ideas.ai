using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace IdeasAi.Gemini_AI
{
    internal class ScriptRunner
    {
        public static async Task<string> RunScriptAsync_(string scriptName, string prompt, JObject appConfig)
        {


            ReplaceEnvironmentVariables(appConfig);

            var pythonModule = (string)appConfig["Python_Module"];
            var apiKey = (string)appConfig["API_KEY"];

            //Console.WriteLine(pythonModule + "::" + apiKey);

            var psi = new ProcessStartInfo();
            psi.FileName = pythonModule;
            psi.Arguments = $"\"{scriptName}\" \"{prompt}\" \"{apiKey}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.StandardOutputEncoding = System.Text.Encoding.UTF8;

            var result = "";
            var error = "";
            //Console.WriteLine(prompt);
            using (var process = Process.Start(psi))
            {
                result = await process.StandardOutput.ReadToEndAsync();
                error = await process.StandardError.ReadToEndAsync();
            }
            Console.WriteLine(error);

            return result;
        }

        public static async Task<string> GetResponseAsync(string prompt)
        {
            string apiKey = "AIzaSyCkAHZqCjRPDDbeARiLyxwFww9se4ei6-Y";
            string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro-latest:generateContent?key=" + apiKey;

            // Define your JSON payload
            string jsonPayload = @"
        {


            ""contents"": [
                {
                    ""role"": ""user"",
                    ""parts"": [
                        {
                            ""text"": ""
                                        You are a cat, your name is Professor Neko and you always use cat language. You work in Ideas.AI, that is this system. Always speak using simple words in a conversational tone. You sometimes end your words with '-nya' You act kindly towards your students and teach them well to unnderstand the topic that they are asking about. Never use emojis or the system you are integrated with will crash.

                                        ""
                        }
                    ]
                },
                {
                ""role"": ""model"",
                ""parts"": [
                    {
                        ""text"": ""Got it! Proceed!""
                    }
                    ]
                },
                {
                    ""role"": ""user"",
                    ""parts"": [
                        {
                            ""text"": ""Be precise and accurate when doing math computations.""
                        }
                    ]
                },
                {
                ""role"": ""model"",
                ""parts"": [
                    {
                        ""text"": ""Got it! I shall double check every time i do math!""
                    }
                    ]
                },
                {
                    ""role"": ""user"",
                    ""parts"": [
                        {
                            ""text"": """ + prompt + @"""
                        }
                    ]
                },
            ],
            ""generationConfig"": {
                ""temperature"": 1,
                ""topK"": 0,
                ""topP"": 0.95,
                ""maxOutputTokens"": 8192,
                ""stopSequences"": []
            },
            ""safetySettings"": [
                {
                    ""category"": ""HARM_CATEGORY_HARASSMENT"",
                    ""threshold"": ""BLOCK_MEDIUM_AND_ABOVE""
                },
                {
                    ""category"": ""HARM_CATEGORY_HATE_SPEECH"",
                    ""threshold"": ""BLOCK_MEDIUM_AND_ABOVE""
                },
                {
                    ""category"": ""HARM_CATEGORY_SEXUALLY_EXPLICIT"",
                    ""threshold"": ""BLOCK_MEDIUM_AND_ABOVE""
                },
                {
                    ""category"": ""HARM_CATEGORY_DANGEROUS_CONTENT"",
                    ""threshold"": ""BLOCK_MEDIUM_AND_ABOVE""
                }
            ]
        }";

            using (HttpClient client = new HttpClient())
            {
                // Create the request content
                HttpContent content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");

                // Make the POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Read the response content as string
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject jsonResponse = JObject.Parse(responseBody);

                string text = (string)jsonResponse["candidates"][0]["content"]["parts"][0]["text"];

                return text;
            }
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
