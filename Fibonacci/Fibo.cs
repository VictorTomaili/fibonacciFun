using System;
using System.Numerics;

namespace Fibonacci 
{
    public static class Fibo
    {
        public static BigInteger Calculate(BigInteger number)
        {
            var fibo = AnonRecursiveFiboFunc<BigInteger>(func => (step, fibo1, fibo2) => 
                step == number
                ? fibo2
                : func(++step, fibo1 + fibo2, fibo1));
            return fibo(0, 1, 0);
        }

        delegate Func<T1, T2, T3, T4> Recursive<T1, T2, T3, T4>(Recursive<T1, T2, T3, T4> r);

        private static Func<T, T, T, T> AnonRecursiveFiboFunc<T>(Func<Func<T, T, T, T>, Func<T, T, T, T>> function)
        {
            Recursive<T, T, T, T> recursive = rec => (step, fibo1, fibo2) => function(rec(rec))(step, fibo1, fibo2);
            return recursive(recursive);
        }
    }
}
