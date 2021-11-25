using static System.Console;

namespace ConsoleApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 17, y = 5; //Declares and sets twio integers to illustrate division.

            // Divides x and y, and stores the results to resultOne as an integer.
            int resultOne = x / y;
            //Prints the resultOne variable to console.
            WriteLine($"{y} goes into {x}, {resultOne} times whole");

            double a = 17, b = 5; 
            double resultTwo = a / b;
            WriteLine($"{a}/{b}={resultTwo}");


        }
    }
}
