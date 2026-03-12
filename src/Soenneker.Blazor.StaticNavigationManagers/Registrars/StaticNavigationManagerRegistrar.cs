using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Soenneker.Blazor.StaticNavigationManagers.Registrars;

/// <summary>
/// Provides a stubbed NavigationManager for static or design-time rendering where navigation is intentionally disabled.
/// </summary>
public static class StaticNavigationManagerRegistrar
{
    /// <summary>
    /// Adds <see cref="StaticNavigationManager"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddStaticNavigationManagerAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<NavigationManager>(_ => new StaticNavigationManager());

        return services;
    }

    /// <summary>
    /// Adds <see cref="StaticNavigationManager"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddStaticNavigationManagerAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<NavigationManager>(_ => new StaticNavigationManager());

        return services;
    }
}
