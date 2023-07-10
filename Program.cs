using OopsConcept.ClassandObject;
using OopsConcept.Inheritance;

namespace OopsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car1 = new Car();
            car1.model = "Maruti";
            car1.color = "red";
            car1.price = "Rs. 3,00,000";
            car1.CarDetails();

            Car car2 = new Car();
            car2.model = "BMW";
            car2.color = "White";
            car2.price = "Rs. 50,00,000";
            car2.CarDetails();

            Animal animal = new Animal();

            Lion lion = new Lion();
        }
    }
}