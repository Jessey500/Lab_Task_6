using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Account
    {
        static void Main(string[] args)
        {
            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("Salma", "122");
            Employee e2 = new Employee("Karim", "123");
            Employee e3 = new Employee("Rakhi", "125");

            b.AddEmployee(e1);
            b.AddEmployee(e2, e3);

            b.ShowAllEmployees();
        }
    }
}
