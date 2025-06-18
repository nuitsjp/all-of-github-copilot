using Shouldly;
using Xunit;

namespace CalculatorApp.Test;

/// <summary>
/// CalculatorクラスのSubtractメソッドのテスト
/// </summary>
public class CalculatorSubtractTests
{
    private readonly Calculator _calculator;

    public CalculatorSubtractTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(1, 1, 0)]
    [InlineData(0, 5, -5)]
    [InlineData(-3, -1, -2)]
    [InlineData(10.5, 5.2, 5.3)]
    [InlineData(-5.5, 3.2, -8.7)]
    [InlineData(double.MaxValue, 0, double.MaxValue)]
    [InlineData(double.MinValue, 0, double.MinValue)]
    public void 正常な減算が実行されること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Subtract(a, b);

        // Assert
        result.ShouldBe(expected, tolerance: 0.0000001);
    }

    [Fact]
    public void 正の無限大からの減算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Subtract(double.PositiveInfinity, 100);

        // Assert
        result.ShouldBe(double.PositiveInfinity);
    }

    [Fact]
    public void 負の無限大からの減算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Subtract(double.NegativeInfinity, 100);

        // Assert
        result.ShouldBe(double.NegativeInfinity);
    }
}