using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc4
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc4 = new Calculator4();

            calc4.GetNumber("First"); calc4.GetNumber("Second");

            calc4.AddNumbers();

            PrintResult(calc4);

            Console.ReadKey(); 
        }

        static void PrintResult(Calculator4 calc)

        {

            //Console.WriteLine($"Your result is {result}.");
            Console.WriteLine(String.Format("Your result is {0}.", calc.Result));
        }
    }
}
