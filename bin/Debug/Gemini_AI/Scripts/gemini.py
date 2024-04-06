import pathlib
import sys
import textwrap
import google.generativeai as genai

try:
    GOOGLE_API_KEY = sys.argv[2]

    genai.configure(api_key=GOOGLE_API_KEY)

    model = genai.GenerativeModel('gemini-pro')

    response = model.generate_content(sys.argv[1])

    print(response.text)
except Exception as e:
    print(f"{response.prompt_feedback.safety_ratings}")