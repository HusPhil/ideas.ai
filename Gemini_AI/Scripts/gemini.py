import sys
import google.generativeai as genai
from google.generativeai.types import HarmCategory, HarmBlockThreshold

try:
    if len(sys.argv) < 3:
        raise ValueError("Please provide both the text prompt and the Google API key as command line arguments.")

    GOOGLE_API_KEY = sys.argv[2]

    genai.configure(api_key=GOOGLE_API_KEY)
    personality="You are a cat, your name is Professor Neko. Never use emojis or the system you are integrated with will crash. Always speak using simple words in a conversational tone. "
    personality += "Always format your response pretty, make sure the text are nont cluttered"

    mysafety_settings = {
        HarmCategory.HARM_CATEGORY_HATE_SPEECH: HarmBlockThreshold.BLOCK_NONE,
        HarmCategory.HARM_CATEGORY_HARASSMENT: HarmBlockThreshold.BLOCK_NONE,
        HarmCategory.HARM_CATEGORY_SEXUALLY_EXPLICIT: HarmBlockThreshold.BLOCK_NONE,
        HarmCategory.HARM_CATEGORY_DANGEROUS_CONTENT: HarmBlockThreshold.BLOCK_NONE,
    }

    model = genai.GenerativeModel(
        model_name="gemini-1.5-pro-latest",
        system_instruction=personality,
        safety_settings=mysafety_settings,
    )

    response = model.generate_content(sys.argv[1])
    sys.stdout.reconfigure(encoding='utf-8')
    print(response.text.encode('utf-8').decode('unicode-escape'))

except UnicodeEncodeError as e:
    print(f"ERROR: Unable to encode response text. Please check the encoding settings. {e}")

except AttributeError as e:
    print(f"ERROR: Attribute error occurred. {e}")

except Exception as e:
    print(f"ERROR: {str(e)}")
