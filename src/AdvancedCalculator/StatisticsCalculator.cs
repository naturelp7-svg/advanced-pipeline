using System;
using System.Linq;

namespace AdvancedCalculatorLib;

public class StatisticsCalculator
{
    public double CalculateAverage(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым");
        return numbers.Average();
    }

    public int FindMax(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым");
        return numbers.Max();
    }

    public int FindMin(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым");
        return numbers.Min();
    }
}
