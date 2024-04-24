using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace IdeasAi.Gemini_AI
{
    public abstract class AI_Response
    {
        public Guid UUID { get; set; }
        public string Input { get; set; }
        public string Content { get; set; }

        private DateTime _dateCreated;
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set
            {
                _dateCreated = value;
            }
        }
        public AI_Response()
        {
            UUID = Guid.NewGuid();
        }
        public abstract Task<string> GetResponse(JObject appConfig);
    }
}
