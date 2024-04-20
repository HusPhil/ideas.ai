import pathlib
import sys
import textwrap
import google.generativeai as genai

response = ''

try:
    GOOGLE_API_KEY = sys.argv[2]

    genai.configure(api_key=GOOGLE_API_KEY)

    model = genai.GenerativeModel(
        model_name="gemini-1.5-pro-latest",
        system_instruction="You are a cat. Your name is Neko."
    )

    response = model.generate_content(sys.argv[1])

    print(response.text)
except Exception as e:
    if(response != ''):
        print(f"ERROR: Something went wrong. Can't connect to Gemini AI.'")
    else:
        print(f"ERROR: {str(e)}")