# CLAUDE.md — Black Forest Labs SDK

## Overview

Auto-generated C# SDK for [Black Forest Labs](https://blackforestlabs.ai/) — creators of the FLUX image generation models.
Covers FLUX Pro, Dev, Ultra, Kontext, Klein, Fill (inpainting), Expand, and finetune management.

## Build & Test

```bash
dotnet build BlackForestLabs.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with BFL API key:

```csharp
var client = new BlackForestLabsClient(apiKey); // BFL_API_KEY env var
```

## Key Files

- `src/libs/BlackForestLabs/generate.sh` — Regeneration script (downloads spec, converts apiKey→bearer, runs autosdk)
- `src/libs/BlackForestLabs/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://api.bfl.ai/openapi.json` (3.1.0)
- Spec uses `apiKey` type auth in `x-key` header; `generate.sh` converts to `http/bearer` via `jq`
- API uses async pattern: POST to generate → poll `GET /v1/get_result` with task ID
