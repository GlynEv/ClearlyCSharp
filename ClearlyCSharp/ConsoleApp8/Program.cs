using static System.Console;

namespace ConsoleApp08
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bobSalary = 65000, jerrySalary = 70000, sallySalary = 75000;
            decimal averageSalary = (bobSalary + jerrySalary + sallySalary) / 3;
            WriteLine($"The average salary at company ABC is {averageSalary}");

        }
    }
}