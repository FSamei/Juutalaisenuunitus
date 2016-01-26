using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hommia10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numValues = 9;
            int[] numbers = new int[numValues] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numValues; i++)
            {
                if (numbers[i] % 2 == 0)

                {
                    Console.WriteLine("tonnikala! on number: " + numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
