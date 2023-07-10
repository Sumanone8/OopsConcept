using OopsConcept.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.ClassandObject
{
    class Car
    {
        //atributes or variable

        public string model;
        public string price;
        public string color;

        public void Drive()
        {
            Console.WriteLine("Car can Drive");
        }
        public void CarDetails()
        {
            Console.WriteLine("Model:{0} Price:{0} Color:{0}", model, price, color);
        }
    }
}