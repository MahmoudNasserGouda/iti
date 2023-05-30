import requests

# Set your API key
API_KEY = "49c5e610c701024cb159ff6056005bab8bdb680392a3f503f11b4d26857f3e79"

# Set the Person Enrichment API URL
PDL_URL = "https://api.peopledatalabs.com/v5/person/enrich"

# Create a parameters JSON object
PARAMS = {
    "api_key": API_KEY,
    "profile": ["https://www.linkedin.com/in/mickeypelletier/"]
}

# Pass the parameters object to the Person Enrichment API
json_response = requests.get(PDL_URL, params=PARAMS).json()

# Print the API response in JSON format
print(json_response)