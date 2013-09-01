using System;
using Fibonacci;

namespace FiboView
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Fibo.Calculate(1000);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
