using Shouldly;
using Xunit;

namespace CalculatorApp.Test;

/// <summary>
/// CalculatorクラスのMultiplyメソッドのテスト
/// </summary>
public class CalculatorMultiplyTests
{
    private readonly Calculator _calculator;

    public CalculatorMultiplyTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(-2, -3, 6)]
    [InlineData(0, 5, 0)]
    [InlineData(5, 0, 0)]
    [InlineData(1, 100, 100)]
    [InlineData(2.5, 4, 10)]
    [InlineData(-3.5, 2, -7)]
    public void 正常な乗算が実行されること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Multiply(a, b);

        // Assert
        result.ShouldBe(expected, tolerance: 0.0000001);
    }

    [Fact]
    public void 正の無限大の乗算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Multiply(double.PositiveInfinity, 2);

        // Assert
        result.ShouldBe(double.PositiveInfinity);
    }

    [Fact]
    public void 負の無限大の乗算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Multiply(double.NegativeInfinity, 2);

        // Assert
        result.ShouldBe(double.NegativeInfinity);
    }

    [Fact]
    public void ゼロとの乗算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Multiply(double.PositiveInfinity, 0);

        // Assert
        double.IsNaN(result).ShouldBeTrue();
    }
}