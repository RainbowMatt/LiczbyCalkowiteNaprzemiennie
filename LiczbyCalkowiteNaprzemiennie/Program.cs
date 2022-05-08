using System;
using System.Collections.Generic;

namespace LiczbyCalkowiteNaprzemiennie
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var x in LiczbyCalkowiteNaprzemiennie(10))
            {
                Console.Write($"{x} ");
            }
        }
        public static IEnumerable<int> LiczbyCalkowiteNaprzemiennie(int n)
        {
            for(int i=0;i<=n;i++)
            {
                if(i%2==0 && i!=0)
                    yield return -i;
                else
                    yield return i;
            }
        }
    }
}
