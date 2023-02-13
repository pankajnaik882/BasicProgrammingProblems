using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class Harmonic
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Enter the a number for harmonic");
            int N = Convert.ToInt32(Console.ReadLine());
            double first = 0.0;

            if (N > 0)
            {
                Console.WriteLine("Hii");
                for (int i = 1; i < N; i++)
                {
                    double temp = i;
                    first = first + (1.0 / i);
                    Console.WriteLine("Harmonic : " + first);
                }
            }
            else
            {
                Console.WriteLine("Please Enter the value greater than 0 ");
            }
        }
    }
}
