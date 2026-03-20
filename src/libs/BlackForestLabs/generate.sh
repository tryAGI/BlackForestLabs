#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://api.bfl.ai/openapi.json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# BFL spec uses apiKey in x-key header. Convert to http/bearer for AutoSDK constructor generation.
# Also add top-level security array.
jq '
  .components.securitySchemes.APIKeyHeader = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"APIKeyHeader": []}]
' openapi.json > openapi_fixed.json && mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace BlackForestLabs \
  --clientClassName BlackForestLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
