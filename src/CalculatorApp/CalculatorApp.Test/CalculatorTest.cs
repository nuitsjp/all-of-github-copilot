using Shouldly;

namespace CalculatorApp.Test;

public class CalculatorTest
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(2, 3);

        // Assert
        result.ShouldBe(5);
    }

    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsDifference()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(5, 3);

        // Assert
        result.ShouldBe(2);
    }

    [Fact]
    public void Subtract_NegativeResult_ReturnsNegativeNumber()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(3, 5);

        // Assert
        result.ShouldBe(-2);
    }

    [Fact]
    public void Subtract_WithZero_ReturnsCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(10, 0);

        // Assert
        result.ShouldBe(10);
    }

    [Fact]
    public void Subtract_ZeroFromNumber_ReturnsNegativeNumber()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(0, 7);

        // Assert
        result.ShouldBe(-7);
    }

    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsProduct()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Multiply(4, 5);

        // Assert
        result.ShouldBe(20);
    }

    [Fact]
    public void Multiply_WithZero_ReturnsZero()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Multiply(5, 0);

        // Assert
        result.ShouldBe(0);
    }

    [Fact]
    public void Divide_ValidInputs_ReturnsQuotient()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(10, 2);

        // Assert
        result.ShouldBe(5);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<DivideByZeroException>(() => calculator.Divide(10, 0))
            .Message.ShouldBe("Cannot divide by zero");
    }

    [Fact]
    public void Add_OverflowCondition_ThrowsOverflowException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Add(int.MaxValue, 1))
            .Message.ShouldBe($"Addition overflow: {int.MaxValue} + 1 exceeds int range");
    }

    [Fact]
    public void Subtract_OverflowCondition_ThrowsOverflowException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Subtract(int.MinValue, 1))
            .Message.ShouldBe($"Subtraction overflow: {int.MinValue} - 1 exceeds int range");
    }

    [Fact]
    public void Multiply_OverflowCondition_ThrowsOverflowException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Multiply(int.MaxValue, 2))
            .Message.ShouldBe($"Multiplication overflow: {int.MaxValue} * 2 exceeds int range");
    }

    [Fact]
    public void Divide_OverflowCondition_ThrowsOverflowException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Divide(int.MinValue, -1))
            .Message.ShouldBe($"Division overflow: {int.MinValue} / -1 exceeds int range");
    }

    [Fact]
    public void Add_LargeNumbers_WithinRange_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(int.MaxValue - 1, 1);

        // Assert
        result.ShouldBe(int.MaxValue);
    }

    [Fact]
    public void Subtract_LargeNumbers_WithinRange_ReturnsDifference()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(int.MinValue + 1, 1);

        // Assert
        result.ShouldBe(int.MinValue);
    }
}