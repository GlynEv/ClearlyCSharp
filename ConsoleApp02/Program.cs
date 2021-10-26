using static System.Console;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 45; // Devclares and sets a variable value
            WriteLine($"Height in 2014= {height}"); // Shows value of variable using string interpolation
            height = 55;
            WriteLine($"Height in 2015= {height}"); // Prints updated value
        }
    }
}
