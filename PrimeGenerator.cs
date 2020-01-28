using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqd
{
    class Program
    {
        static void Main(string[] args)
        {
            //nth prime number?
            int counter = 0;

            foreach(var x in generatePrime())
            {
                if (x == 10001)
                    break;
            }

            Console.ReadLine();


        }



        static IEnumerable<int> generatePrime()
        {

            int curNum = 2;
            int count = 0;

            while(true)
            {
                if(IsPrime(curNum))
                {
                    Console.WriteLine(curNum);
                    count++;
                    yield return count;
                }
                curNum++;
            }
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

         
    }
}
