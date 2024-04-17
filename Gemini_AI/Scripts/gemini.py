import pathlib
import sys
import textwrap
import google.generativeai as genai

response = ''

try:
    GOOGLE_API_KEY = sys.argv[2]

    genai.configure(api_key=GOOGLE_API_KEY)

    model = genai.GenerativeModel('gemini-1.5-pro-latest')

    response = model.generate_content(sys.argv[1])

    print(response.text)
except Exception as e:
    if(response != ''):
        print(f"ERROR: Inappropriate prompt was deteced!")
    else:
        print(f"ERROR: {str(e)}")