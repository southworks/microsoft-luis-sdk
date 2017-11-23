# LUIS Runtime Client SDK

> see https://westus.dev.cognitive.microsoft.com/docs/services/5819c76f40a6350ce09de1ac/operations/5819c77140a63516d81aee78

``` yaml
input-file:
 - LUIS-Endpoint-API.swagger.json

version: 2.0
override-client-name: LuisClient

csharp:
  namespace: Microsoft.Azure.CognitiveServices.Language.LUIS
  output-folder: .NET/LUIS-Runtime/Generated

nodejs:
  generate-metadata: false
  output-folder: JavaScript
```