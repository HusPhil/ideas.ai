import sys
import google.generativeai as genai
from google.generativeai.types import HarmCategory, HarmBlockThreshold

try:
    if len(sys.argv) < 3:
        raise ValueError("Please provide both the text prompt and the Google API key as command line arguments.")

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

except UnicodeEncodeError as e:
    print(f"ERROR: Unable to encode response text. Please check the encoding settings. {e}")

except AttributeError as e:
    print(f"ERROR: Attribute error occurred. {e}")

except Exception as e:
    print(f"ERROR: {str(e)}")
