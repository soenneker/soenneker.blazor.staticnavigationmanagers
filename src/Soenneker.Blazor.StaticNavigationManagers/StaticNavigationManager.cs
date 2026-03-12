using Microsoft.AspNetCore.Components;

namespace Soenneker.Blazor.StaticNavigationManagers;

/// <summary>
/// Provides a navigation manager implementation for static rendering scenarios where navigation is not supported.
/// </summary>
/// <remarks>This class is intended for use in environments where interactive navigation is unnecessary or
/// unavailable, such as during prerendering or static site generation. Attempts to navigate using this manager will
/// have no effect.</remarks>
public sealed class StaticNavigationManager : NavigationManager
{
    public StaticNavigationManager()
    {
        Initialize("https://localhost/", "https://localhost/");
    }

    protected override void NavigateToCore(string uri, bool forceLoad)
    {
        // No-op for static render
    }
}
