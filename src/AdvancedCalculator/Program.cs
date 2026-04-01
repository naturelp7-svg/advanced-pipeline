using AdvancedCalculatorLib;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var stats = new StatisticsCalculator();
            Console.WriteLine("=== опндбхмсрши йюкэйскърнп ===");
            Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"2^4 = {calculator.Power(2, 4)}");
            Console.WriteLine($"5! = {calculator.Factorial(5)}");
            Console.WriteLine($"17 опнярне вхякн? {calculator.IsPrime(17)}");
            Console.WriteLine($"япедмее [1,2,3,4,5] = {stats.CalculateAverage(1, 2, 3, 4, 5)}");
            Console.WriteLine($"люйяхлсл [1,5,3,9,2] = {stats.FindMax(1, 5, 3, 9, 2)}");
            Console.WriteLine("\nбяе ноепюжхх бшонкмемш сяоеьмн!");
        }
    }
}
