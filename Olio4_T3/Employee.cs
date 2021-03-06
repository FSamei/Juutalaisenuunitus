﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary
        { 
          get { return salary;}
    set {if (value >= 0.0f) salary = value; else salary = 0.0f;}
}

        public Employee(string name, string profession, float salary)
        { Name = name;
            Profession = profession;
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        private float salary;
    }
}
