using System;
using System.Numerics;

namespace Fibonacci 
{
    public static class Fibo
    {
        public static BigInteger Calculate(BigInteger a)
        {
            var fibos = AnonRecursiveFiboFunc<BigInteger>(func => (i, fibos1, fibos2) => i == a
                ? fibos2
                : func(i + 1, fibos1 + fibos2, fibos1));
            return fibos(0, 1, 0);
        }

        delegate Func<TArg1, TArg2, TArg3, TArg4>
            Recursive<TArg1, TArg2, TArg3, TArg4>(Recursive<TArg1, TArg2, TArg3, TArg4> r);

        private static Func<TArg, TArg, TArg, TArg> AnonRecursiveFiboFunc<TArg>(Func<Func<TArg, TArg, TArg, TArg>, Func<TArg, TArg, TArg, TArg>> function)
        {
            Recursive<TArg, TArg, TArg, TArg> rec = r => (i, b, c) => function(r(r))(i, b, c);
            return rec(rec);
        }
    }
}
