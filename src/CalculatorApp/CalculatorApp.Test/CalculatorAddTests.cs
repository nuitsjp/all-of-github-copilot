using Shouldly;
using Xunit;

namespace CalculatorApp.Test;

/// <summary>
/// Calculatorクラスのaddメソッドのテスト
/// </summary>
public class CalculatorAddTests
{
    private readonly Calculator _calculator;

    public CalculatorAddTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(10.5, 20.3, 30.8)]
    [InlineData(-5.5, -3.2, -8.7)]
    [InlineData(double.MaxValue, 0, double.MaxValue)]
    [InlineData(double.MinValue, 0, double.MinValue)]
    public void 正常な加算が実行されること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Add(a, b);

        // Assert
        result.ShouldBe(expected, tolerance: 0.0000001);
    }

    [Fact]
    public void 正の無限大の加算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Add(double.PositiveInfinity, 100);

        // Assert
        result.ShouldBe(double.PositiveInfinity);
    }

    [Fact]
    public void 負の無限大の加算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Add(double.NegativeInfinity, 100);

        // Assert
        result.ShouldBe(double.NegativeInfinity);
    }
}