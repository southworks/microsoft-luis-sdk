# Cognitive Services LUIS SDKs

> see https://aka.ms/autorest

Configuration for generating LUIS SDKs.

``` yaml
add-credentials: true
openapi-type: data-plane
```

The current release for the Runtime Endpoint is `runtime_2_0`.

The current release for the Programmatic Endpoint is `programmatic_2_0`.

# Releases

## Runtime 2.0
These settings apply only when `--tag=runtime_2_0` is specified on the command line.

``` yaml $(tag) == 'runtime_2_0'
input-file: v2.0/LUIS-Endpoint-API.swagger.json
```

### Runtime 2.0 - CSharp Settings
These settings apply only when `--tag=runtime_2_0` and `--csharp` are specified on the command line.
``` yaml $(tag) == 'runtime_2_0' && $(csharp)
csharp:
  override-client-name: LuisRuntimeAPI
  sync-methods: None
  license-header: MICROSOFT_MIT_NO_VERSION
  azure-arm: false
  namespace: Microsoft.Azure.CognitiveServices.Language.LUIS
  #output-folder: $(csharp-sdks-folder)/CognitiveServices/dataPlane/LUIS/LUIS-Runtime/Generated
  output-folder: ../../.NET/LUIS-Runtime/Generated
  clear-output-folder: true
```

## Programmatic 2.0
These settings apply only when `--tag=programmatic_2_0` is specified on the command line.

``` yaml $(tag) == 'programmatic_2_0'
input-file: v2.0/LUIS-Programmatic-API.swagger.json
```

### Programmatic 2.0 - CSharp Settings
These settings apply only when `--tag=programmatic_2_0` and `--csharp` are specified on the command line.
``` yaml $(tag) == 'programmatic_2_0' && $(csharp)
csharp:
  override-client-name: LuisProgrammaticAPI
  sync-methods: None
  license-header: MICROSOFT_MIT_NO_VERSION
  azure-arm: false
  namespace: Microsoft.Azure.CognitiveServices.Language.LUIS
  #output-folder: $(csharp-sdks-folder)/CognitiveServices/dataPlane/LUIS/LUIS-Programmatic/Generated
  output-folder: ../../.NET/LUIS-Programmatic/Generated
  clear-output-folder: true
```