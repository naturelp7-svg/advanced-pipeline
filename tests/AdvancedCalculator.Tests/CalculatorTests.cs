using Xunit;
using AdvancedCalculatorLib;

namespace AdvancedCalculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-2, 7, 5)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(3, 2, 9)]
    [InlineData(5, 0, 1)]
    public void Power_ReturnsCorrectResult(int baseNum, int exponent, int expected)
    {
        var result = _calculator.Power(baseNum, exponent);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 120)]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    public void Factorial_ReturnsCorrectResult(int n, int expected)
    {
        var result = _calculator.Factorial(n);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(17, true)]
    [InlineData(4, false)]
    [InlineData(1, false)]
    public void IsPrime_ReturnsCorrectResult(int number, bool expected)
    {
        var result = _calculator.IsPrime(number);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }

    [Fact]
    public void Factorial_NegativeNumber_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Factorial(-5));
    }
}
