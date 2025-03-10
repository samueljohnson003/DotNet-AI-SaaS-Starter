# .NET AI SaaS Starter Kit

Opinionated starter for building AI-powered SaaS applications with clean architecture, LLM integration, and modern tooling.

## Included

- Clean architecture (Api, Application, Domain, Infrastructure)
- LLM service abstraction
- Example AI endpoints
- Docker and CI support
- React frontend skeleton

## Structure

```
src/
├── Api/                 # Entry point and controllers
├── Application/         # Services
├── Domain/              # Models
└── Infrastructure/      # Implementations

frontend/                # React app
.github/workflows/       # CI
```

## Getting Started

```bash
cd src/Api && dotnet run
cd frontend && npm install && npm run dev
```

## Roadmap

- [x] Clean architecture base
- [x] LLM abstraction
- [x] Docker / CI
- [ ] Full auth
- [ ] Billing integration

MIT
