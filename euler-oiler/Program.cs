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
        }
    }
}