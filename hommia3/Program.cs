using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hommia3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numValues = 3;
            int total = 0;
            for (int i=0; i<numValues; i++)
            {
                Console.Write("heitä biitti: ");
                int number = 0;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    total += number;
                }
                else
                {
                    Console.WriteLine("invalid user - exiting");
                    break;
                }
            }
            Console.WriteLine("Sum of numbers is: " + total);
            Console.WriteLine("AVG of numbers is: " + total / numValues);
            Console.ReadLine();

        }
    }
}
