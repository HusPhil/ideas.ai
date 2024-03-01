using System;
using System.Threading.Tasks;
using IdeasAi.Gemini_AI;

namespace IdeasAi.Ideas
{
    internal class Idea : AI_Response
    {
        public string Title { get; set; }
        public override async Task<string> GetResponse()
        {
            var prompt = "Pretend you are an expert about providing useful ideas. " +
                "If the topic is not valid or vague, suggest other topics to explore instead. " +
                "Make a table, and make a column for each subtopic." +
                "The rows of each columns must provide brief information, significance, project ideas, and research ideas about the subtopics." +
                "Below the table, supply further information and explain the topic and its subtopic for the summary to make sure a dummy could understand it." +
                "Finally, make an outline about the topic as well as some references on where the user can learn more." +
                $"The topic supplied: {this.Input}.";

            string response = await ScriptRunner.RunScriptAsync("Gemini_AI\\Scripts\\gemini.py", prompt);
            this.DateCreated = DateTime.Now;
             
            return response;
        }

        public override void SaveData()
        {
            throw new System.NotImplementedException();
        }
    }
}
