using Microsoft.AspNetCore.Components;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Blazor.StaticNavigationManagers.Tests;

[Collection("Collection")]
public sealed class StaticNavigationManagerTests : FixturedUnitTest
{
    private readonly NavigationManager _util;

    public StaticNavigationManagerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<NavigationManager>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
