using System;
using System.Numerics;

namespace Fibonacci 
{
    public static class Fibo
    {
        public static BigInteger Calculate(BigInteger a)
        {
            Func<BigInteger, BigInteger, BigInteger, BigInteger> fibo = 
                AnonRecursiveFiboFunc<BigInteger, BigInteger, BigInteger, BigInteger>(func => (i, fibo1, fibo2) => i == a
                ? fibo2
                : func(i + 1, fibo1 + fibo2, fibo1));
            return fibo(0, 1, 0);
        }


        delegate Func<TArgi, TArgfibo1, TArgfibo2, TReturned> 
            Recursive<TArgi, TArgfibo1, TArgfibo2, TReturned>(Recursive<TArgi, TArgfibo1, TArgfibo2, TReturned> r);
        static Func<TArgi, TArgfibo1, TArgfibo2, TReturned>
            AnonRecursiveFiboFunc<TArgi, TArgfibo1, TArgfibo2, TReturned>(
            Func<Func<TArgi, TArgfibo1, TArgfibo2, TReturned>,
            Func<TArgi, TArgfibo1, TArgfibo2, TReturned>> f)
        {
            Recursive<TArgi, TArgfibo1, TArgfibo2, TReturned> rec = r => (i, b, c) => f(r(r))(i, b, c);
            return rec(rec);
        }
    }
}
