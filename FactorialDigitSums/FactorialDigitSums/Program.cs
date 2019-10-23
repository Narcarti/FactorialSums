using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigMath;

namespace FactorialDigitSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialSum(100));

            Console.ReadLine();
        }

        static public int FactorialSum( int n)
        {
            //using long results in 0  being returned
            BigInteger f = 1;
            int s = 0;

            for (; n > 1;)
            {
                
                f *= n--;
            }

            //enumerate through each number in factorial
            //then add each num to get result
            foreach (var num in f.ToString().ToList())
            {
                //add "" to allow parsing of string to int
                s += int.Parse(num + "");
            }

            return s;
        }
    }
}
