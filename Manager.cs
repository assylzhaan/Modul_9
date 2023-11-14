using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9HW
{
    class Manager : Employee
    {

        public double bonus;


        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            this.bonus = bonus;
        }


        public override double CalculateAnnualSalary()
        {

            double baseSalary = base.CalculateAnnualSalary();

            double totalSalary = baseSalary + bonus;

            return totalSalary;
        }
    }
}
