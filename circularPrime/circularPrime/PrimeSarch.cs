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

        public int amount;

        public PrimeSarch(int finalNumber = 1000000)
        {
            amount = findAmountCircularPrime(findAllPrimes(finalNumber));
        }

        private static List<int> findAllPrimes(int final) //search all primes
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


        private static int findAmountCircularPrime(List<int> primeNumber)//search all circular prime
        {
            int circularPrimeAmount = 0;

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
                    ++circularPrimeAmount;

                i.ToString();

            }


            return circularPrimeAmount;
        }

    }
}
