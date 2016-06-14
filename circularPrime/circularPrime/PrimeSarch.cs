using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circularPrime
{
    class PrimeSarch
    {
        

        static PrimeSarch()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(circularPrimeSearcher(seekerPrimes()));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
        }

        private static List<int> seekerPrimes(int final=1000000) //search all primes
        {
            List<int> primeNumber = new List<int>();
            primeNumber.Add(2);
            int i = 3;

            while(i<=final)
            {
                bool flag = true;

                foreach(int j in primeNumber)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    primeNumber.Add(i);
                }
                i += 2;
            }
            return primeNumber;
        }


        private static int circularPrimeSearcher(List<int> primeNumber)//search all circular prime
        {
            List<int> circularPrimeAmount = new List<int>();

            foreach(int i in primeNumber)
            {

                bool flag = true;
                int j = 1;
                string tmp = i.ToString();
                while (j < tmp.Length)
                {
                    tmp = tmp.Substring(1) + tmp[0];
                    int nextNumber = Int32.Parse(tmp);
                    if (!(primeNumber.Contains(nextNumber)))
                    {
                        flag = false;
                        break;
                    }
                    ++j;

                }

                if (flag)
                    circularPrimeAmount.Add(i);

                i.ToString();



            }


            return circularPrimeAmount.Count;
        }

    }
}
