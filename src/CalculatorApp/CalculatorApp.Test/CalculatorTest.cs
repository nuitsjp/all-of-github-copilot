using Xunit;
using Shouldly;

namespace CalculatorApp.Tests
{
    /// <summary>
    /// Calculator クラスのテスト
    /// </summary>
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -3, -2)]
        [InlineData(100, -50, 150)]
        [InlineData(-10, 5, -15)]
        public void Subtract_正常な値で減算_正しい結果を返す(int a, int b, int expected)
        {
            // Arrange
            // パラメーターで設定済み

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Subtract_最大値から1を減算_正しい結果を返す()
        {
            // Arrange
            var a = int.MaxValue;
            var b = 1;
            var expected = int.MaxValue - 1;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Subtract_最小値から負の1を減算_正しい結果を返す()
        {
            // Arrange
            var a = int.MinValue;
            var b = -1;
            var expected = int.MinValue + 1;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Subtract_最小値から1を減算_OverflowExceptionが発生する()
        {
            // Arrange
            var a = int.MinValue;
            var b = 1;

            // Act & Assert
            Should.Throw<OverflowException>(() => _calculator.Subtract(a, b));
        }

        [Fact]
        public void Subtract_最大値から負の最大値を減算_OverflowExceptionが発生する()
        {
            // Arrange
            var a = int.MaxValue;
            var b = int.MinValue;

            // Act & Assert
            Should.Throw<OverflowException>(() => _calculator.Subtract(a, b));
        }
    }
}