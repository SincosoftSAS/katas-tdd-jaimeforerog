using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -3, -8)]
        [InlineData(10, -3, 7)]
        public void Add_Numbers_ReturnsSum(int a, int b, int expected)
        {
            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(5, 0, 5)]
        [InlineData(-5, -3, -2)]
        [InlineData(0, 5, -5)]
        public void Subtract_Numbers_ReturnsDifference(int a, int b, int expected)
        {
            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(10, 4, 40)]
        [InlineData(5, 0, 0)]
        [InlineData(-5, -3, 15)]
        [InlineData(5, -3, -15)]
        public void Multiply_Numbers_ReturnsProduct(int a, int b, int expected)
        {
            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(0, 5, 0)]
       [InlineData(10, 3, 3)]
        public void Divide_Numbers_ReturnsQuotient(int a, int b, int expected)
        {
            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(expected);
        }
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Act
            Action act = () => _calculator.Divide(10, 0);

            // Assert
            act.Should().ThrowExactly<InvalidOperationException>()
                .WithMessage("No se puede dividir de 0 o numero negativos.");
        }
    }
}