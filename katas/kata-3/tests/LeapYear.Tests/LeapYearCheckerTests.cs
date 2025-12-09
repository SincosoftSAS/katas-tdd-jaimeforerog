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
            // Ejemplo: 2001 no es año bisiesto
             Assert.False(LeapYearChecker.IsLeapYear(2001));
         }
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100ButDivisible400_IsLeapYear()
        {
            // Ejemplo: 2001 no es año bisiesto
            Assert.True(LeapYearChecker.IsLeapYear(2000));
        }
        [Fact]
        public void Year_IsNegative_throwException()
        {
            
            Action act = () => LeapYearChecker.IsLeapYear(-2000);

            // Assert
            act.Should().ThrowExactly<ArgumentOutOfRangeException>();
        }
        [Fact]
        public void Year_IsMayor4000_throwExceptionn()
        {
            
            Action act = () => LeapYearChecker.IsLeapYear(4000);

            // Assert
            act.Should().ThrowExactly<ArgumentOutOfRangeException>();
        }
        
    }
}
