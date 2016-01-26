using System;

namespace Juutalaisenuunitus
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int number = 0;
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;

                    case 2:
                        Console.WriteLine("Two");
                        break;

                    case 3:
                        Console.WriteLine("Three");
                        break;

                    case 4:
                        Console.WriteLine("Four");
                        break;

                    default:
                        Console.WriteLine("Unknown number");
                        break;
                }
                while (number != 0) ;
                Console.WriteLine("All done - exiting app");
            }
        }
    }
}
