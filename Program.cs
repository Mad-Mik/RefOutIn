using System;

namespace RefOutIn
{
    public class Person
    {
        static void Main(string[] args)
        {
            // ref/out/in
            int m = 4;
            Console.WriteLine(m);
            Sum(ref m, 5, out int k);
            Console.WriteLine(m);
            Console.WriteLine(k);

        }
        static int Sum(ref int m, int n, out int k)
        {
            k = 0;
            m++;
            int S = m + n + k;
            return S;
        }
    }
}
