
using Xunit;
using AdvancedCalculatorLib;

namespace AdvancedCalculator.Tests;

public class StatisticsCalculatorTests
{
    private readonly StatisticsCalculator _stats = new();

    [Fact]
    public void CalculateAverage_ReturnsCorrectAverage()
    {
        var result = _stats.CalculateAverage(1, 2, 3, 4, 5);
        Assert.Equal(3, result);
    }

    [Fact]
    public void CalculateAverage_EmptyArray_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _stats.CalculateAverage());
    }

    [Fact]
    public void FindMax_ReturnsMaximum()
    {
        var result = _stats.FindMax(1, 5, 3, 9, 2);
        Assert.Equal(9, result);
    }

    [Fact]
    public void FindMin_ReturnsMinimum()
    {
        var result = _stats.FindMin(1, 5, 3, 9, 2);
        Assert.Equal(1, result);
    }
}
