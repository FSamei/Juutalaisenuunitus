using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hommia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add seconds: ");

            int seconds = 0;
            string s = Console.ReadLine();
            if (int.TryParse(s, out seconds))
            {
                int hours = seconds / 3600;
                seconds -= hours * 3600;
                
                int minutes = seconds / 60;
                seconds -= minutes * 60;
                                
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minutes);
                Console.WriteLine("Seconds: " + seconds);
            }
        }
    }
}
