using Xunit;
using Shouldly;
using CalculatorApp;

namespace CalculatorApp.Test;

public class CalculatorTests
{
    public class Add
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(0, 0, 0)]
        [InlineData(10, -5, 5)]
        [InlineData(int.MaxValue, 0, int.MaxValue)]
        [InlineData(int.MinValue, 0, int.MinValue)]
        public void Add_正しい引数を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            ////////////////////////////////////////////////////////////////////////
            // Arrange
            ////////////////////////////////////////////////////////////////////////
            var calculator = new Calculator();

            ////////////////////////////////////////////////////////////////////////
            // Act
            ////////////////////////////////////////////////////////////////////////
            var result = calculator.Add(a, b);

            ////////////////////////////////////////////////////////////////////////
            // Assert
            ////////////////////////////////////////////////////////////////////////
            result.ShouldBe(expected);
        }
    }
}