using FluentAssertions;
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
        [Fact]
        public void Calculate_fiveNumbers_ReturnsSum()
        {
            
            Assert.Equal(15, Calculator.Calculate("1,2,3,4,5"));
        }
        [Fact]
        public void Calculate_NumbersAndSpace_ReturnsSum()
        {

            Assert.Equal(6, Calculator.Calculate("1\n2,3"));
        }

        [Fact]
        public void Calculate_CustomDelimiter_ReturnsSum()
        {

            Assert.Equal(3, Calculator.Calculate("//;\n1;2"));
        }
        [Fact]
        public void Calculate_NegativeNumber_ReturnsException()
        {

            var caller = () => Calculator.Calculate("1,-2,3,-4");
           
            caller.Should().ThrowExactly<ArgumentOutOfRangeException>().WithMessage("Negativos no permitidos -2,-4");
        }
        [Fact]
        public void Calculate_NumberMayor1000_ReturnSumNumberMenor()
        {

            Assert.Equal(2, Calculator.Calculate("2,1001"));
        }

        [Fact]
        public void Calculate_MultiCharacterDelimiter_ReturnsSum()
        {

            Assert.Equal(6, Calculator.Calculate("//[***]\n1***2***3"));
        }
     
    }
}