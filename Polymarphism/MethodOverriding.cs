using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymarphism
{
    internal class Employee
    {
        public string Name;
        public double Salary;
        public virtual void GetSalary()
        {
            Console.WriteLine("5,000");
        }
        public void EmployeeDetails()
        {
            Console.WriteLine("Name:(0)Salary:(0)", Name,Salary);
        }
    }
    class PartTime:Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("10,000");
        }
    }
}
