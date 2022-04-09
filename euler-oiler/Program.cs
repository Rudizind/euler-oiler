using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_oiler
{
    public class Program
    {
        static void Main(string[] Args)
        {
            ProduceOutputs();
        }

        private static void ProduceOutputs()
        {
            var EulerSolver = new EulerSolver();

            Console.WriteLine(String.Format("1. The sum of all multiples of 3 and 5 that are less than 1000 is {0}", EulerSolver.SolveProblemOne()));
            Console.WriteLine(String.Format("2. The sum of all even fibonacci numbers less than 4,000,000 is {0}", EulerSolver.SolveProblemTwo()));
            Console.WriteLine(String.Format("3. The largest prime factor of x 600851475143 is {0}", EulerSolver.SolveProblemThree()));
            Console.WriteLine(String.Format("4. The largest palindrome formed from two three-digit numbers is {0}", EulerSolver.SolveProblemFour()));
            Console.WriteLine(String.Format("5. The lowest integer that is evenly divisble by numbers 1-20 is {0}", EulerSolver.SolveProblemFive()));
        }
    }
}