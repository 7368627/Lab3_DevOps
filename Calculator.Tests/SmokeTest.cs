using Xunit;

namespace Calculator.Tests;

public class SmokeTest
{
    [Fact]
    public void Application_Should_StartSuccessfully()
    {
        Assert.Equal(5, 2);
    }
}