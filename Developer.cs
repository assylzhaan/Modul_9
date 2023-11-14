using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9HW
{
    class Developer : Employee
    {
        public int linesOfCodePerDay;


        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            double baseSalary = base.CalculateAnnualSalary();

            double additionalPayment = linesOfCodePerDay * 0.1;

            double totalSalary = baseSalary + additionalPayment;

            return totalSalary;
        }
    }
}
