using System;

namespace IdeasAi.Gemini_AI
{
    internal abstract class AI_Response
    {
        public Guid UUID { get; set; }
        public AI_Response()
        {
            UUID = Guid.NewGuid();
        }

        private string input;
        public string Input {
            get { return input; }
            set {
                input = value;
                Content = GetResponse(input);
            }
        }
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

        public abstract string GetResponse(string input);
        public abstract void SaveData();
    }
}
