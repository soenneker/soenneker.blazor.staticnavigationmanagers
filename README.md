[![](https://img.shields.io/nuget/v/soenneker.blazor.staticnavigationmanagers.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.staticnavigationmanagers/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.staticnavigationmanagers/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.staticnavigationmanagers/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.staticnavigationmanagers.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.staticnavigationmanagers/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.staticnavigationmanagers/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.staticnavigationmanagers/actions/workflows/codeql.yml)

# Soenneker.Blazor.StaticNavigationManagers

A no-op `NavigationManager` for isolated component rendering, previews, and tests where no browser or navigation host exists.

## Installation

```bash
dotnet add package Soenneker.Blazor.StaticNavigationManagers
```

## Registration

Choose the lifetime that matches the service graph used by your renderer:

```csharp
using Soenneker.Blazor.StaticNavigationManagers.Registrars;

services.AddStaticNavigationManagerAsSingleton();
```

or:

```csharp
services.AddStaticNavigationManagerAsScoped();
```

Both methods register the instance as Blazor's `NavigationManager`, so components can inject their normal dependency:

```razor
@inject NavigationManager Navigation

<button @onclick="() => Navigation.NavigateTo('/next')">Next</button>
```

With this implementation the click handler completes, but the URI does not change and no navigation event is raised.

## Exact behavior

- `BaseUri` and `Uri` are both initialized to `https://localhost/`.
- Relative URI helpers therefore resolve against that placeholder origin.
- `NavigateTo(...)` and operations routed through it have no effect.
- The manager does not detect prerendering, static SSR, or interactivity.
- The registration methods use `TryAdd`; they do not replace a `NavigationManager` that is already registered.

That last point makes registration order significant. Add this service only to the standalone service collection used for static rendering or tests, before resolving components from it.

## When not to use it

Do not register this manager in an interactive Blazor application. It disables navigation rather than adapting it to the current render mode, and its placeholder origin is unsuitable for generating production absolute URLs.

Do not rely on a swallowed navigation call to enforce authentication or authorization. If a component normally redirects unauthorized users, this manager will leave the component rendering; access control must be enforced independently by the host and data layer.
