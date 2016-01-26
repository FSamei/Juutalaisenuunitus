using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee antti = new Employee("Antti Lohtaja ", "dota", 4200.50f);
            Boss sami = new Boss("Sami Oravasaari", "rekt", 9000.0f, "Audi", 5000.0f);

            antti.Salary += 1000.0f;
            sami.Salary -= 2000.0f;
            sami.Bonus = 1000.0f;
            Console.WriteLine(Employee.tostring)
        }
    }
}
