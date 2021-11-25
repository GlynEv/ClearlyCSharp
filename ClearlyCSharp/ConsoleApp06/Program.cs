using static System.Console;

namespace ConsoleApp06
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salary = 75000M;
            decimal rate = 0.67M;
            WriteLine($"Salary is {salary * rate}.");
        }
    }
}
