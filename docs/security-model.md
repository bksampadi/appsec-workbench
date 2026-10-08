# Security Model

AppSec Workbench currently exposes a single read-only API for security findings.

## Attack surface

```mermaid
flowchart LR
    U["🌐 Untrusted client"]

    subgraph W["AppSec Workbench"]
        C["FindingsController"]
        F["SecurityFinding"]
        C --> F
    end

    U -->|"GET /api/findings"| C
    R["⚠ No authentication yet"] -.-> C

    classDef client fill:#EAF2FF,stroke:#6B8FD6,color:#1E2A3A,stroke-width:1.5px;
    classDef app fill:#E8F5EC,stroke:#67A97A,color:#193522,stroke-width:1.5px;
    classDef risk fill:#FFF4D6,stroke:#D6A94A,color:#3A2D12,stroke-width:1.5px;

    class U client;
    class C,F app;
    class R risk;
```

## Current assumptions

- findings are read-only
- there is no authentication or authorization yet
- there is no database or external integration
- only development data is exposed

Security finding data should be treated as sensitive once real findings are stored.

## Reassess when

Revisit this model when adding authentication, write operations, persistence,
scanner integrations, source-code access, or multiple users.