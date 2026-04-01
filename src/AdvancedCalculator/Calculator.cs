namespace AdvancedCalculatorLib;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль!");
        return (double)a / b;
    }

    public int Power(int baseNum, int exponent)
    {
        if (exponent < 0)
            throw new ArgumentException("Степень не может быть отрицательной");
        return (int)Math.Pow(baseNum, exponent);
    }

    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал отрицательного числа не определён");
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
