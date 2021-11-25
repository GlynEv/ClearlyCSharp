using static System.Console;

namespace ConsoleApp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5; // Declares and sets two variables on one line.
            int sum = x + y; // stores the sum to the variable.
            WriteLine($"Sum={sum}"); //shows the end of the calculation.
            int product = x * y;
            WriteLine($"Sum={product}"); //shows the muliplication of the two variables.
            int difference = x - y;
            WriteLine($"Difference={difference}"); //shows the muliplication of the two variables.
        }
    }
}
