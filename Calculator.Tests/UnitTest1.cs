namespace Calculator.Tests;
using Xunit;


public class UnitTest1
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var calculator = new CalculatorClass();

        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
    }
}
