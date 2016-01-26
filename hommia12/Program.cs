using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hommia12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numValues = 5;
            int[] numbers = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.Write("Add a number: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Numbers in reverse order");
            for (int i = numValues - 1; i >= 0; i--)
            {
                Console.WriteLine("tonnikala! on number: " + numbers[i]);
            }
            
            Console.ReadLine();
        }
    }
}
