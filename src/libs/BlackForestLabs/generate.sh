#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.bfl.ai/openapi.json

readonly openapi_url="https://api.bfl.ai/openapi.json"
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.json \
  --namespace BlackForestLabs \
  --clientClassName BlackForestLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
