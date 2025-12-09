using Xunit;

namespace StringCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate_EmptyString_ReturnsZero()
        {
      
            var result = Calculator.Calculate("");
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            
            Assert.Equal(3, Calculator.Calculate("1,2"));
        }
    }
}