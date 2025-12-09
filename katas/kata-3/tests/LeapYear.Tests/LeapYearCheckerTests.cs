using FluentAssertions;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100_IsLeapYear()
        {
            // Ejemplo: 2004 es año bisiesto
            Assert.True(LeapYearChecker.IsLeapYear(2004));
        }

        [Fact]
        public void Year_NotDivisibleBy4_IsNotLeapYear()
        {
   
             Assert.False(LeapYearChecker.IsLeapYear(2001));
         }
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100ButDivisible400_IsLeapYear()
        {
      
            Assert.True(LeapYearChecker.IsLeapYear(2000));
        }
        [Fact]
        public void Year_IsNegative_throwException()
        {
            
            Action act = () => LeapYearChecker.IsLeapYear(-2000);

   
            act.Should().ThrowExactly<ArgumentOutOfRangeException>();
        }
        [Fact]
        public void Year_IsMayor4000_throwException()
        {
            
            Action act = () => LeapYearChecker.IsLeapYear(4000);

          
            act.Should().ThrowExactly<ArgumentOutOfRangeException>();
        }
        [Theory]
        [InlineData(1900)]
        [InlineData(1800)]
        [InlineData(2100)]
        public void Year_DivisibleBy100_ButNotBy400_IsNotLeapYear(int year)
        {
            Assert.False(LeapYearChecker.IsLeapYear(year));
        }
    }
}
