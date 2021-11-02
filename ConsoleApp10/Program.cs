using static System.Console;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter value to grow by 2");

            double number = double.Parse(ReadLine());

            WriteLine($"{number} increased by 2 {number + 2}");

        }
    }
}
