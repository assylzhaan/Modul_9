//Arapova Assylzhan
//1
using Modul9HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9HW
{
    class Employee
    {
        public string name;
        public int age;
        public double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        }


        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }

   

 

    class Program
    {
        static void Main()
        {
            Manager manager1 = new Manager("Arapova Assylzhan", 21, 100000, 50000);

        
            manager1.GetInfo();

            double annualSalaryManager = manager1.CalculateAnnualSalary();
            Console.WriteLine($" Salary (Manager): {annualSalaryManager}");

            Console.WriteLine();


            Developer developer1 = new Developer("Bolatbek Aigerim", 20, 60000, 50000);

            developer1.GetInfo();

            double annualSalaryDeveloper = developer1.CalculateAnnualSalary();
            Console.WriteLine($"Salary (Developer): {annualSalaryDeveloper}");
            Console.ReadKey();
        }
    }


}


