# LUIS Client SDKs

> see https://docs.microsoft.com/en-us/azure/cognitive-services/LUIS/Home

``` yaml
input-file:
 - https://raw.githubusercontent.com/stevengum97/azure-rest-api-specs/luis/luisSwaggerFiles/specification/cognitiveservices/data-plane/Luis/v2.0/LUIS%20Endpoint%20API.swagger.json

version: 2.0
override-client-name: LuisClient

csharp:
  namespace: Microsoft.CognitiveServices.LUIS
  output-folder: .NET

nodejs:
  generate-metadata: false
  output-folder: JavaScript

# typescript:
#   package-name: microsoft-luis-runtime-sdk
#   package-version: 2.0
#   output-folder: TypeScript
```