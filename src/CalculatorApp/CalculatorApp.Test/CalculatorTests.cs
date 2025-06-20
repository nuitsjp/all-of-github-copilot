using Xunit;
using Shouldly;
using CalculatorApp;

namespace CalculatorApp.Test
{
    public class CalculatorTests
    {
        public class Subtract
        {
            [Theory]
            [InlineData(5, 3, 2)]
            [InlineData(0, 0, 0)]
            [InlineData(-1, -1, 0)]
            [InlineData(int.MaxValue, 1, int.MaxValue - 1)]
            [InlineData(int.MinValue, 0, int.MinValue)]
            public void Subtract_正しい引数を渡した場合_正しい結果を返す(int a, int b, int expected)
            {
                ////////////////////////////////////////////////////////////////////////
                // Arrange
                ////////////////////////////////////////////////////////////////////////
                var calculator = new Calculator();

                ////////////////////////////////////////////////////////////////////////
                // Act
                ////////////////////////////////////////////////////////////////////////
                var result = calculator.Subtract(a, b);

                ////////////////////////////////////////////////////////////////////////
                // Assert
                ////////////////////////////////////////////////////////////////////////
                result.ShouldBe(expected);
            }
        }
    }
}
