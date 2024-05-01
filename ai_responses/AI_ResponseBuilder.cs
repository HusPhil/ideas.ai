using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using System;

namespace IdeasAi.ai_responses
{
    public class AI_ResponseBuilder<T> where T : AI_Response, new()
    {
        private T ai_response = new T();

        public AI_ResponseBuilder<T> WithInput(string input)
        {
            ai_response.Input = input;
            return this;
        }

        public AI_ResponseBuilder<T> WithContent(string content)
        {
            ai_response.Content = content;
            return this;
        }

        public AI_ResponseBuilder<T> WithTitle(string title)
        {
            ai_response.Title = title;
            return this;
        }

        public T Build()
        {
            return ai_response;
        }
    }
}
