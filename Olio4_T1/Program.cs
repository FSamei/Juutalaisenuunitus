using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio5_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Audi", "cool");
            Console.WriteLine(mycar.ToString());

            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());

            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "195/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "195/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "195/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "195/65R15"));
            Console.WriteLine(mycar.ToString());

            Console.ReadLine();
        }
    }
}
