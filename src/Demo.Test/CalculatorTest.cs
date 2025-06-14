using Xunit;
using Shouldly;
using System;

namespace Demo
{
    public class CalculatorTest
    {
        private Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        #region Add Method Tests

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;
            int expected = -8;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -4;
            int expected = 6;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            // Arrange
            int a = 7;
            int b = 0;
            int expected = 7;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Add_BothZero_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int expected = 0;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        #endregion

        #region Divide Method Tests

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_NegativeByPositive_ReturnsNegativeQuotient()
        {
            // Arrange
            int a = -10;
            int b = 2;
            int expected = -5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_PositiveByNegative_ReturnsNegativeQuotient()
        {
            // Arrange
            int a = 10;
            int b = -2;
            int expected = -5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_TwoNegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int a = -10;
            int b = -2;
            int expected = 5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 5;
            int expected = 0;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Should.Throw<ArgumentException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_NumberNotEvenlyDivisible_ReturnsIntegerQuotient()
        {
            // Arrange
            int a = 7;
            int b = 3;
            int expected = 2; // Integer division truncates

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Divide_SameNumbers_ReturnsOne()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 1;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        #endregion
    }
}