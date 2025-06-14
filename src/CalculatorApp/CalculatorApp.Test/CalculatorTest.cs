using Shouldly;

namespace CalculatorApp.Test;

public class CalculatorTest
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(int.MaxValue - 1, 1, int.MaxValue)]
    public void Add_ValidInputs_ReturnsSum(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(3, 5, -2)]
    [InlineData(10, 0, 10)]
    [InlineData(0, 7, -7)]
    [InlineData(int.MinValue + 1, 1, int.MinValue)]
    public void Subtract_ValidInputs_ReturnsDifference(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [InlineData(4, 5, 20)]
    [InlineData(5, 0, 0)]
    public void Multiply_ValidInputs_ReturnsProduct(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Multiply(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    public void Divide_ValidInputs_ReturnsQuotient(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(a, b);

        // Assert
        result.ShouldBe(expected);
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

    [Theory]
    [InlineData(int.MaxValue, 1, "Addition")]
    public void Add_OverflowCondition_ThrowsOverflowException(int a, int b, string operation)
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Add(a, b))
            .Message.ShouldBe($"{operation} overflow: {a} + {b} exceeds int range");
    }

    [Theory]
    [InlineData(int.MinValue, 1, "Subtraction")]
    public void Subtract_OverflowCondition_ThrowsOverflowException(int a, int b, string operation)
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Subtract(a, b))
            .Message.ShouldBe($"{operation} overflow: {a} - {b} exceeds int range");
    }

    [Theory]
    [InlineData(int.MaxValue, 2, "Multiplication")]
    public void Multiply_OverflowCondition_ThrowsOverflowException(int a, int b, string operation)
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Multiply(a, b))
            .Message.ShouldBe($"{operation} overflow: {a} * {b} exceeds int range");
    }

    [Theory]
    [InlineData(int.MinValue, -1, "Division")]
    public void Divide_OverflowCondition_ThrowsOverflowException(int a, int b, string operation)
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<OverflowException>(() => calculator.Divide(a, b))
            .Message.ShouldBe($"{operation} overflow: {a} / {b} exceeds int range");
    }


}