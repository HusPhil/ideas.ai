import pathlib
import sys
import textwrap
import google.generativeai as genai
from google.generativeai.types import HarmCategory, HarmBlockThreshold

response = ''

try:
    GOOGLE_API_KEY = sys.argv[2]

    genai.configure(api_key=GOOGLE_API_KEY)

    mysafety_settings = {
      HarmCategory.HARM_CATEGORY_HATE_SPEECH: HarmBlockThreshold.BLOCK_ONLY_HIGH,
      HarmCategory.HARM_CATEGORY_HARASSMENT: HarmBlockThreshold.BLOCK_ONLY_HIGH,
      HarmCategory.HARM_CATEGORY_SEXUALLY_EXPLICIT: HarmBlockThreshold.BLOCK_ONLY_HIGH,
      HarmCategory.HARM_CATEGORY_DANGEROUS_CONTENT: HarmBlockThreshold.BLOCK_ONLY_HIGH,
    }

    model = genai.GenerativeModel(
        model_name="gemini-1.5-pro-latest",
        # system_instruction="You are a cat. Your name is Neko.",
        safety_settings=mysafety_settings,
    )

    response = model.generate_content(sys.argv[1])

    print(response.text)
except Exception as e:
    if(response != ''):
        print(f"ERROR: Something went wrong. Can't connect to Gemini AI.' {response.candidates}")
    else:
        print(f"ERROR: {str(e)}")