using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int a = random.Next();
            int b = random.Next();
            var calc = new Calculator();
            int sum = calc.Add(a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
