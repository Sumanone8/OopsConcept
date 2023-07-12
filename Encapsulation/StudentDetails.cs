using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Encapsulation
{
    internal class StudentDetails
    {
        private string studentName;
        private int age;

        public string Name
        {
            get { return studentName; }
            set 
            {
                if (value.Length >= 3)
                    studentName = value;
                else
                    Console.WriteLine("Please enter valid name. Name should have 3 or more then 3 characters!");
            }
        }
        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age should be greater then 0!");
            }
        }
        public void StudentData()
        {
            Console.WriteLine("Name:{0} Age:{1}",studentName,age);
        }
    }
}
