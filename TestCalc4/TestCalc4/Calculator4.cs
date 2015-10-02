using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc4
{
    class Calculator4
    {
        double[] numbers = new double[2];

        public double First 
        { 
            get 
            { 
                return numbers[0];
            }
        }

        public double Second 
        { 
            get 
            { 
                return numbers[1];
            }
        }

        double result;

        public double Result 
        { 
            get { return result; } 
            set { result = value; }
        }

        public void GetNumber(string whichNumber)
        {
            Console.Write(/*$*/"{whichNumber} Number: "); 
            string numberInput = Console.ReadLine(); 
            double number = double.Parse(numberInput);

            if (whichNumber == "First") numbers[0] = number; 
            else numbers[1] = number; 
        }

        public void AddNumbers() 
        {
            Result = First + Second;
        }

        public void PrintResult()
        {
        Console.WriteLine(/*$*/"\nYour result is {result}.");
        }
    }
}
