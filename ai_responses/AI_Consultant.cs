using System;
using System.Threading.Tasks;
using IdeasAi.Gemini_AI;
using Newtonsoft.Json.Linq;

namespace IdeasAi.Ideas
{
    public class AI_Consultant : AI_Response
    {
        public override async Task<string> GetResponse(JObject appConfig)
        {
            var prompt = "Pretend you are a teacher that answers a student's question. " +
                "You use simple language and talk like a person in a conversatonal tone in answering the supplied question by your student. " +
                "You give them all the relevant information they need about their question. " +
                "You provide long and detailed information as if you are on a long lecture. " +
                "You structure your answer so the student would not be able to simply copy paste it as his/her homework. " +
                "You also format your answer in an organized way, making it easier for the eyes of the reader. " +
                "You also summarizes beautifully in simplest way all the information you have given. " +
                "You also use tables as visual aid in making sure that the student is understanding the answer clearly. " +
                "You only give a pseudocode when asked for a code; REMEMBER THAT YOU ARE NOT SUPPOSED TO GIVE AN ANSWER THAT WILL JUST BE COPY PASTED. " +
                "Finally, you provide more learning references where the student can learn more and provide them with more specific questions based on their question. " +
                
                $"The question supplied: {this.Input.Replace("\"", "'")}.";

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
