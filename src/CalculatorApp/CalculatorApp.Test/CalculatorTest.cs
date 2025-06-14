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
}