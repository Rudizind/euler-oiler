using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_oiler
{
    public class MathHelper
    { 
        public static long GetHighestPrimeFactor(long currentDividend)
        {
            List<long> factorList = GetPrimeFactors(currentDividend);

            return factorList.Max();
        }

        // gets prime factors other than itself and 1
        public static List<long> GetPrimeFactors(long currentDividend)
        {
            var factorList = new List<long>() { 1 };
            var currentDivisor = 2;
            while (currentDividend > 1)
            {
                while (currentDividend % currentDivisor == 0)
                {
                    factorList.Add(currentDivisor);
                    currentDividend /= currentDivisor;
                }

                currentDivisor++;

                if (currentDivisor * currentDivisor > currentDividend)
                {
                    if (currentDividend > 1)
                    {
                        factorList.Add(currentDividend);
                        break;
                    }
                }
            }

            return factorList;
        }

        public static long GetSumOfNatNumSquares(IEnumerable<int> listOfNatNums)
        {
            return (long)listOfNatNums.Sum(d => Math.Pow(d, 2));
        }

        public static long GetSquareOfNatNumSums(IEnumerable<int> listOfNatNums)
        {
            var totalSum = listOfNatNums.Sum();

            return (long)Math.Pow(totalSum, 2);
        }
    }
}
