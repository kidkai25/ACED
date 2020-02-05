using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<long>();

            foreach (var x in getPrime(2000000))
                list.Add(x);

            //list.ForEach(Console.WriteLine);
            Console.WriteLine(list.Sum());
            Console.ReadLine();
        }

        static IEnumerable<long> getPrime(int n)
        {
            int currentNum = 2;
            bool isNotPrime = false;

            while ( currentNum <= n)
            {
                for(int i = 2; i <= Math.Sqrt((int)currentNum); i++)
                {
                    if (currentNum % i == 0) {
                        isNotPrime = true;
                        break;
                    }

                }

                if (isNotPrime)
                    isNotPrime = false; //resetting
                
                else
                    yield return currentNum;
                currentNum++;
            }
        }
    }
}
