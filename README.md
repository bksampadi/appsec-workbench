# AppSec Workbench

AppSec Workbench is an application security engineering project for investigating
security findings from detection through root-cause analysis and verified remediation.

The project is built around a simple workflow:

**find → reproduce → trace → understand → fix → verify**

## Current status

Early development.

The current implementation includes:

- ASP.NET Core API
- initial security finding domain model
- read-only findings API endpoint

## Development

Build:

```bash
dotnet build
```

Run:

```bash
dotnet run --project src/AppSecWorkbench.Api
```

The development API Exposes:

```
GET /api/findings
```