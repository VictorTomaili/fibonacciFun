using System;
using Math;

namespace FiboView
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Fibonacci.Calc(1000);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
