using Xunit;
using System;

namespace Demo.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = Calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -3;

            // Act
            int result = Calculator.Add(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 3;

            // Act
            int result = Calculator.Subtract(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Subtract_ResultingInNegative_ReturnsNegativeNumber()
        {
            // Arrange
            int a = 3;
            int b = 10;

            // Act
            int result = Calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-7, result);
        }

        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int a = 4;
            int b = 5;

            // Act
            int result = Calculator.Multiply(a, b);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act
            int result = Calculator.Multiply(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;

            // Act
            double result = Calculator.Divide(a, b);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_WithRemainder_ReturnsDecimalQuotient()
        {
            // Arrange
            int a = 7;
            int b = 2;

            // Act
            double result = Calculator.Divide(a, b);

            // Assert
            Assert.Equal(3.5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
        }
    }
}