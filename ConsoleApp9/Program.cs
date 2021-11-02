using static System.Console;

namespace ConsoleApp09
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Salary:");

            string input = ReadLine();

            decimal salary = decimal.Parse(input);

            WriteLine($"33% of {salary} is {salary * 0.33M:C}")

        }
    }
}