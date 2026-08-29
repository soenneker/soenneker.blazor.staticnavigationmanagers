[![](https://img.shields.io/nuget/v/soenneker.blazor.staticnavigationmanagers.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.staticnavigationmanagers/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.staticnavigationmanagers/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.staticnavigationmanagers/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.staticnavigationmanagers.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.staticnavigationmanagers/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.staticnavigationmanagers/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.staticnavigationmanagers/actions/workflows/codeql.yml)

# Soenneker.Blazor.StaticNavigationManagers

Provides a stubbed NavigationManager for static or design-time rendering where navigation is intentionally disabled.

## Install

```bash
dotnet add package Soenneker.Blazor.StaticNavigationManagers
```

## Quick start

```csharp
using Soenneker.Blazor.StaticNavigationManagers.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddStaticNavigationManagerAsSingleton();
```

Adds `StaticNavigationManager` as a singleton service.

## What you get

- `StaticNavigationManagerRegistrar` — Provides a stubbed NavigationManager for static or design-time rendering where navigation is intentionally disabled.
- `StaticNavigationManager` — Provides a navigation manager implementation for static rendering scenarios where navigation is not supported.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `StaticNavigationManagerRegistrar.AddStaticNavigationManagerAsSingleton(services)` | Adds `StaticNavigationManager` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `StaticNavigationManagerRegistrar.AddStaticNavigationManagerAsScoped(services)` | Adds `StaticNavigationManager` as a scoped service. | The same service collection, so additional registrations can be chained. |

## Important behavior

- `StaticNavigationManager`: This class is intended for use in environments where interactive navigation is unnecessary or unavailable, such as during prerendering or static site generation. Attempts to navigate using this manager will have no effect.
