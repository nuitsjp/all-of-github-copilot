using Shouldly;
using Xunit;

namespace CalculatorApp.Test;

/// <summary>
/// CalculatorクラスのDivideメソッドのテスト
/// </summary>
public class CalculatorDivideTests
{
    private readonly Calculator _calculator;

    public CalculatorDivideTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    [InlineData(-6, 2, -3)]
    [InlineData(-6, -2, 3)]
    [InlineData(0, 5, 0)]
    [InlineData(7.5, 2.5, 3)]
    [InlineData(1, 3, 0.3333333333333333)]
    public void 正常な除算が実行されること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Divide(a, b);

        // Assert
        result.ShouldBe(expected, tolerance: 0.0000001);
    }

    [Fact]
    public void ゼロ除算で例外が発生すること()
    {
        // Arrange - コンストラクタで実施済み

        // Act & Assert
        Should.Throw<DivideByZeroException>(() => _calculator.Divide(10, 0))
            .Message.ShouldBe("除数は0にできません。");
    }

    [Fact]
    public void ゼロをゼロで除算した時に例外が発生すること()
    {
        // Arrange - コンストラクタで実施済み

        // Act & Assert
        Should.Throw<DivideByZeroException>(() => _calculator.Divide(0, 0))
            .Message.ShouldBe("除数は0にできません。");
    }

    [Fact]
    public void 負のゼロで除算した時に例外が発生すること()
    {
        // Arrange - コンストラクタで実施済み

        // Act & Assert
        Should.Throw<DivideByZeroException>(() => _calculator.Divide(10, -0.0))
            .Message.ShouldBe("除数は0にできません。");
    }

    [Fact]
    public void 正の無限大の除算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Divide(double.PositiveInfinity, 2);

        // Assert
        result.ShouldBe(double.PositiveInfinity);
    }

    [Fact]
    public void 負の無限大の除算が正しく処理されること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Divide(double.NegativeInfinity, 2);

        // Assert
        result.ShouldBe(double.NegativeInfinity);
    }

    [Fact]
    public void 有限値を無限大で除算すると0になること()
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Divide(100, double.PositiveInfinity);

        // Assert
        result.ShouldBe(0);
    }
}