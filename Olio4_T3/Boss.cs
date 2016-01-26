using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public float Bonus { get; set; }
        public Boss(string name, string profession, float salary, string car, float bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }
    }
}
