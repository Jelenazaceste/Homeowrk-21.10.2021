using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeowrk_21._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 219, 34, 145, 510 };
            int sum = 0;
            foreach (int number in intArray)
            { sum += number; }

            {
                Console.WriteLine(sum);
            }
            Console.ReadLine();

        }
    }
}
