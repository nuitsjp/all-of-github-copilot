using Xunit;
using Shouldly;
using CalculatorApp;
using System;

public class CalculatorTests
{
    public class Power
    {
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 0, 1)]
        [InlineData(-2, 3, -8)]
        [InlineData(2, -2, 0.25)]
        [InlineData(9, 0, 1)]
        [InlineData(0, 5, 0)]
        [InlineData(1.5, 2, 2.25)]
        public void Power_正常な引数を渡した場合_正しい結果を返す(double baseValue, int exponent, double expected)
        {
            ////////////////////////////////////////////////////////////////////////
            // Arrange
            ////////////////////////////////////////////////////////////////////////
            var calculator = new Calculator();

            ////////////////////////////////////////////////////////////////////////
            // Act
            ////////////////////////////////////////////////////////////////////////
            var result = calculator.Power(baseValue, exponent);

            ////////////////////////////////////////////////////////////////////////
            // Assert
            ////////////////////////////////////////////////////////////////////////
            result.ShouldBe(expected, 0.00001);
        }

        [Theory]
        [InlineData(double.NaN, 2)]
        [InlineData(double.PositiveInfinity, 2)]
        [InlineData(double.NegativeInfinity, 2)]
        public void Power_不正な底を渡した場合_ArgumentExceptionをスローする(double baseValue, int exponent)
        {
            ////////////////////////////////////////////////////////////////////////
            // Arrange
            ////////////////////////////////////////////////////////////////////////
            var calculator = new Calculator();

            ////////////////////////////////////////////////////////////////////////
            // Act & Assert
            ////////////////////////////////////////////////////////////////////////
            Should.Throw<ArgumentException>(() => calculator.Power(baseValue, exponent));
        }
    }
}
