using Xunit;
using Shouldly;
using CalculatorApp;

namespace CalculatorApp.Test
{
    public class CalculatorTests
    {
        public class Add
        {
            [Theory]
            [InlineData(1, 2, 3)]
            [InlineData(-1, -2, -3)]
            [InlineData(0, 0, 0)]
            [InlineData(int.MaxValue - 1, 1, int.MaxValue)]
            public void Add_正しい引数を渡した場合_正しい結果を返す(int a, int b, int expected)
            {
                var calculator = new Calculator();
                var result = calculator.Add(a, b);
                result.ShouldBe(expected);
            }

            [Theory]
            [InlineData(int.MaxValue, 1)]
            [InlineData(int.MinValue, -1)]
            public void Add_オーバーフローが発生する場合_OverflowExceptionをスローする(int a, int b)
            {
                var calculator = new Calculator();
                Should.Throw<OverflowException>(() => calculator.Add(a, b));
            }
        }

        public class Multiply
        {
            [Theory]
            [InlineData(2, 3, 6)]
            [InlineData(-2, 3, -6)]
            [InlineData(-2, -3, 6)]
            [InlineData(0, 5, 0)]
            [InlineData(5, 0, 0)]
            [InlineData(1, int.MaxValue, int.MaxValue)]
            [InlineData(-1, int.MaxValue, -int.MaxValue)]
            public void Multiply_正しい引数を渡した場合_正しい結果を返す(int a, int b, int expected)
            {
                // Arrange
                var calculator = new Calculator();

                // Act
                var result = calculator.Multiply(a, b);

                // Assert
                result.ShouldBe(expected);
            }

            [Theory]
            [InlineData(int.MaxValue, 2)]
            [InlineData(int.MinValue, 2)]
            [InlineData(2, int.MaxValue)]
            [InlineData(-2, int.MinValue)]
            public void Multiply_オーバーフローが発生する場合_OverflowExceptionをスローする(int a, int b)
            {
                // Arrange
                var calculator = new Calculator();

                // Act & Assert
                Should.Throw<OverflowException>(() => calculator.Multiply(a, b));
            }
        }
    }
}
