using OopsConcept.Abstraction;
using OopsConcept.ClassandObject;
using OopsConcept.Encapsulation;
using OopsConcept.Inheritance;
using OopsConcept.Polymarphism;

namespace OopsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("1.ClassAndObject concept\n2.Inheritance\n3.Polymarphism\n4.Abstraction\n5.Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Car car = new Car();
                    Car car1 = new Car();
                    car1.model = "Maruti";
                    car1.color = "red";
                    car1.price = "3,00,000";
                    car1.CarDetails();
                    Car car2 = new Car();
                    car2.model = "BMW";
                    car2.color = "White";
                    car2.price = "50,00,000";
                    car2.CarDetails();
                    break;
                case 2:
                    Lion lion = new Lion();
                    lion.name = "Lion";
                    lion.Run();
                    break;
                case 3:
                    Addition addition = new Addition();
                    Addition.Add(10,30);
                    Addition.Add(10, 30, 50.23);
                    break;
                case 4:
                    PartTime parttime = new PartTime();
                    parttime.GetSalary();
                    parttime.Name = "Harsh";
                    parttime.Salary = 15000;
                    parttime.EmployeeDetails();
                    break;
                case 5:
                    SBIAtm atm = new SBIAtm();
                    atm.WithdrawMoney();
                    atm.ConnectingToBackEnd();
                    break;
                case 6:
                    StudentDetails student = new StudentDetails();
                    student.studentDetails = "ab";
                    student.age = 30;
                    student.StudentData();
                    break;
                default:
                    Console.WriteLine("Please Choose program whithin the given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}