@echo off

REM Validate Endpoint Spec and Samples

CALL oav validate-spec .\v2.0\LUIS-Endpoint-API.swagger.json

CALL oav validate-example .\v2.0\LUIS-Endpoint-API.swagger.json