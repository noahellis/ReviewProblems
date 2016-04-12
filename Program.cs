using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomIteratorProblem testCustomIterator = new CustomIteratorProblem();            
            foreach (string flightData in testCustomIterator)
            {
                Console.Write(flightData);
            }
            Console.ReadKey();
        }
    }
}
