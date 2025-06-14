using Shouldly;
using UtilityLibrary;

namespace CalculatorApp.Test;

public class StringUtilitiesTests
{
    #region TrimStart Tests

    [Theory]
    [InlineData("  hello", "hello")]
    [InlineData("\t\nworld", "world")]
    [InlineData("   spaces   ", "spaces   ")]
    [InlineData("no leading spaces", "no leading spaces")]
    public void TrimStart_ValidInputs_RemovesLeadingWhitespace(string input, string expected)
    {
        // Arrange & Act
        var result = StringUtilities.TrimStart(input);

        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void TrimStart_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = "";

        // Act
        var result = StringUtilities.TrimStart(input);

        // Assert
        result.ShouldBe("");
    }

    [Fact]
    public void TrimStart_NullInput_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => StringUtilities.TrimStart(input))
            .ParamName.ShouldBe("input");
    }

    #endregion

    #region TrimEnd Tests

    [Theory]
    [InlineData("hello  ", "hello")]
    [InlineData("world\t\n", "world")]
    [InlineData("   spaces   ", "   spaces")]
    [InlineData("no trailing spaces", "no trailing spaces")]
    public void TrimEnd_ValidInputs_RemovesTrailingWhitespace(string input, string expected)
    {
        // Arrange & Act
        var result = StringUtilities.TrimEnd(input);

        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void TrimEnd_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = "";

        // Act
        var result = StringUtilities.TrimEnd(input);

        // Assert
        result.ShouldBe("");
    }

    [Fact]
    public void TrimEnd_NullInput_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => StringUtilities.TrimEnd(input))
            .ParamName.ShouldBe("input");
    }

    #endregion

    #region TrimBoth Tests

    [Theory]
    [InlineData("  hello  ", "hello")]
    [InlineData("\t\nworld\t\n", "world")]
    [InlineData("   spaces   ", "spaces")]
    [InlineData("no spaces", "no spaces")]
    [InlineData("  ", "")]
    [InlineData("\t\n", "")]
    public void TrimBoth_ValidInputs_RemovesBothLeadingAndTrailingWhitespace(string input, string expected)
    {
        // Arrange & Act
        var result = StringUtilities.TrimBoth(input);

        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void TrimBoth_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = "";

        // Act
        var result = StringUtilities.TrimBoth(input);

        // Assert
        result.ShouldBe("");
    }

    [Fact]
    public void TrimBoth_NullInput_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => StringUtilities.TrimBoth(input))
            .ParamName.ShouldBe("input");
    }

    #endregion
}