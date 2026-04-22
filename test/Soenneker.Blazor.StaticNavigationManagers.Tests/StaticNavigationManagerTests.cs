using Microsoft.AspNetCore.Components;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Blazor.StaticNavigationManagers.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class StaticNavigationManagerTests : HostedUnitTest
{
    private readonly NavigationManager _util;

    public StaticNavigationManagerTests(Host host) : base(host)
    {
        _util = Resolve<NavigationManager>(true);
    }

    [Test]
    public void Default()
    {

    }
}
