#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.presenton.ai/api-reference/openapi.json
autosdk generate openapi.yaml \
  --namespace Presenton \
  --clientClassName PresentonClient \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
