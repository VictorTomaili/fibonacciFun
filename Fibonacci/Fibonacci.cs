using System;
using System.Numerics;

namespace Math
{
    public static class Fibonacci
    {
        public static BigInteger Calc(int a)
        {
            var fibo = AnonRecursiveFibonacciFunc<int,BigInteger>(func => 
                (step, fib1, fib2) => 
                    step == a
                    ? fib2
                    : func(++step, fib1 + fib2, fib1));
            return fibo(0, 1, 0);
        }

        private delegate Fun<T1,T> Recursive<T1,T>(Recursive<T1,T> r);

        private delegate T Fun<in T1, T>(T1 arg1, T arg2, T arg3);

        private static Fun<T1, T> 
            AnonRecursiveFibonacciFunc<T1, T>(Func<Fun<T1, T>, Fun<T1, T>> function)
        {
            Recursive<T1,T> recursive = r => (step, b, c) => function(r(r))(step, b, c);
            return recursive(recursive);
        }
    }
}
