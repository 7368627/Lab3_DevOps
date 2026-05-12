using Xunit;

namespace Calculator.Tests
{
    public class SmokeTests
    {
        [Fact(DisplayName = "SmokeTest_VerifyOneEqualsOne")]
        public void SmokeTest_VerifyOneEqualsOne()
        {
            Assert.Equal(1, 1);
        }

        [Fact(DisplayName = "SmokeTest_CanAddNumbers")]
        public void SmokeTest_CanAddNumbers()
        {
            var calc = new CalculatorClass();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }
    }
}