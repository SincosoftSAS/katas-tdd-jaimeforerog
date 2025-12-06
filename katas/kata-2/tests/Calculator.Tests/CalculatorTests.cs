using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(8);
        }
        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(6);
        }
        [Fact]
        public void multiply_TwoNumbers_ReturnMultiplication()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(40);
        }
        [Fact]
        public void divide_TwoNumbers_ReturnDivision(){
            // Arrange
            int a = 10;
            int b = 2;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(5);
        }

        // TODO: Implementa más tests usando TDD
        // Suggestions:
        // - Test multiply with positive numbers
        // - Test divide with positive numbers  
        // - Test edge cases (division by zero, negative numbers, etc.)
    }
}