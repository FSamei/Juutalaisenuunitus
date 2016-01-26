using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hommia16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int randomNumber = new Random().Next(0, 100);
            do
            {

                Console.Write("Try to quess number in between 0-100: ");
                int number = int.Parse(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("Correct! - exiting application");
                    done = true;
                }
                else if (number < randomNumber)
                {
                    Console.WriteLine("Your number is smaller than mine...");

                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Your number is bigger than mine...");
                }

            } while (!done); 
        }
    }
}
