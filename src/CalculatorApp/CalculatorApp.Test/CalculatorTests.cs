using Xunit;
using Shouldly;
using System;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        #region Add メソッドのテスト

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-5, 3, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -5, -15)]
        public void 加算_正常な値を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void 加算_int最大値を超える場合_OverflowExceptionをスローする()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 1;

            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Add(a, b));
            exception.Message.ShouldContain("Addition overflow");
        }

        [Fact]
        public void 加算_int最小値を下回る場合_OverflowExceptionをスローする()
        {
            // Arrange
            int a = int.MinValue;
            int b = -1;

            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Add(a, b));
            exception.Message.ShouldContain("Addition overflow");
        }

        #endregion

        #region Subtract メソッドのテスト

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-5, 3, -8)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -5, -5)]
        public void 減算_正常な値を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void 減算_int最小値を下回る場合_OverflowExceptionをスローする()
        {
            // Arrange
            int a = int.MinValue;
            int b = 1;

            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Subtract(a, b));
            exception.Message.ShouldContain("Subtraction overflow");
        }

        [Fact]
        public void 減算_int最大値を超える場合_OverflowExceptionをスローする()
        {
            // Arrange
            int a = int.MaxValue;
            int b = -1;

            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Subtract(a, b));
            exception.Message.ShouldContain("Subtraction overflow");
        }

        #endregion

        #region Multiply メソッドのテスト

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-5, 3, -15)]
        [InlineData(0, 100, 0)]
        [InlineData(-10, -5, 50)]
        public void 乗算_正常な値を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(int.MaxValue, 2)]
        [InlineData(int.MinValue, -2)]
        [InlineData(100000, 100000)]
        public void 乗算_オーバーフローする場合_OverflowExceptionをスローする(int a, int b)
        {
            // Arrange
            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Multiply(a, b));
            exception.Message.ShouldContain("Multiplication overflow");
        }

        #endregion

        #region Divide メソッドのテスト

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-15, 3, -5)]
        [InlineData(0, 5, 0)]
        [InlineData(-20, -4, 5)]
        public void 除算_正常な値を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void 除算_ゼロで除算する場合_DivideByZeroExceptionをスローする()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            var exception = Should.Throw<DivideByZeroException>(() => _calculator.Divide(a, b));
            exception.Message.ShouldBe("Cannot divide by zero");
        }

        [Fact]
        public void 除算_int最小値を負の1で除算する場合_OverflowExceptionをスローする()
        {
            // Arrange
            int a = int.MinValue;
            int b = -1;

            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Divide(a, b));
            exception.Message.ShouldContain("Division overflow");
        }

        #endregion
    }
}
