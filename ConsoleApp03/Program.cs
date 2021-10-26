using static System.Console;

namespace ConsoleApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salary = 65000M; // We need something to change so we can use the debugger
            WriteLine($"Salary is {salary}."); //prints value to screen
            salary = 75000M;//updates variable value
            WriteLine($"Salary is {salary}."); // Prints updated value of variable

        }
    }
}
