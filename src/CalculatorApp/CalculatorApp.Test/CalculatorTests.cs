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

        #region Power メソッドのテスト

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(3, 2, 9)]
        [InlineData(5, 0, 1)]
        [InlineData(0, 5, 0)]
        [InlineData(1, 100, 1)]
        [InlineData(-1, 2, 1)]
        [InlineData(-1, 3, -1)]
        [InlineData(-2, 3, -8)]
        [InlineData(-3, 2, 9)]
        [InlineData(10, 1, 10)]
        public void 累乗_正常な値を渡した場合_正しい結果を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(-5, 0, 1)]
        [InlineData(100, 0, 1)]
        public void 累乗_指数が0の場合_1を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 10, 0)]
        [InlineData(0, 100, 0)]
        public void 累乗_底が0の場合_0を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 50, 1)]
        [InlineData(1, 1000, 1)]
        public void 累乗_底が1の場合_1を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(-1, 2, 1)]
        [InlineData(-1, 4, 1)]
        [InlineData(-1, 100, 1)]
        public void 累乗_底がマイナス1で指数が偶数の場合_1を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, 3, -1)]
        [InlineData(-1, 99, -1)]
        public void 累乗_底がマイナス1で指数が奇数の場合_マイナス1を返す(int baseNumber, int exponent, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Power(baseNumber, exponent);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(5, -1)]
        [InlineData(10, -5)]
        [InlineData(-3, -2)]
        public void 累乗_負の指数を渡した場合_ArgumentOutOfRangeExceptionをスローする(int baseNumber, int exponent)
        {
            // Arrange
            // Act & Assert
            var exception = Should.Throw<ArgumentOutOfRangeException>(() => _calculator.Power(baseNumber, exponent));
            exception.ParamName.ShouldBe("exponent");
            exception.Message.ShouldContain("Exponent must be non-negative");
        }

        [Theory]
        [InlineData(int.MaxValue, 2)]
        [InlineData(1000, 10)]
        [InlineData(100, 5)]
        public void 累乗_オーバーフローする場合_OverflowExceptionをスローする(int baseNumber, int exponent)
        {
            // Arrange
            // Act & Assert
            var exception = Should.Throw<OverflowException>(() => _calculator.Power(baseNumber, exponent));
            exception.Message.ShouldContain("Power overflow");
        }

        #endregion
    }
}
