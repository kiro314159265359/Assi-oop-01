using System.Drawing;

namespace Assi_oop_01
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo

            #region Struct
            // onstructor initialize with default values
            // struct : value tpye : stack

            // id , name , salary

            // Point point;
            // decalre object from type "point"


            //Console.WriteLine(point.x);
            //Console.WriteLine(point.y);

            //cant work coz its un assigend

            //point.x = 3;
            //point.y = 5;

            //Console.WriteLine(point.x);
            //Console.WriteLine(point.y);

            //Point point = new Point(1,2);
            //Console.WriteLine(point.x);


            //Point poinT = new Point();
            //Console.WriteLine(poinT.x);

            ////point.print("Hi");

            //Console.WriteLine(poinT.ToString());


            #endregion

            #region OOP

            // oop : paradim to build any buissness
            // 1. Encapsultaion
            // 2. Inhertance
            // 3. Polymorphism
            // 4. Abstruction


            #endregion

            #region Encapsulation

            // separation of data from it's users

            //Employee p01 = new Employee();

            //p01.SetId = 1;
            //p01.name = "Test";
            //p01.salary = 3000.0;

            //Console.WriteLine(p01.id);
            //Console.WriteLine(p01.name);
            //Console.WriteLine(p01.salary);

            // end users can ecess data itself thats a problem 

            //p01.SetId(1);
            //p01.SetName("k");
            //p01.SetSalary(3000.0);

            //Console.WriteLine(p01.GetName() +" "+ p01.GetSalary());

            #endregion

            #region Property

            //// full perperty
            //// Automatic property You cant add restrections
            //// spicial property [Indexer]

            //Employee person = new Employee();

            //// person.Id = 1;
            //person.Name = "Test";
            //person.Salary = -200.0;
            //person.Address = "Alex";

            //Console.WriteLine(person.Id);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Salary);
            //Console.WriteLine(person.Address);

            #endregion

            #region spicial property [Indexer]

            //PhoneBook phoneBook = new PhoneBook(3);

            //phoneBook.AddContact("Test01",23155353501,0);
            //phoneBook.AddContact("Test02", 23155353502, 1);
            //phoneBook.AddContact("Test03", 23155353503, 2);

            ////Console.WriteLine(phoneBook.GetNumber("Test01"));

            ////phoneBook.UpdateNumber("Test01",1234);

            ////Console.WriteLine(phoneBook.GetNumber("Test01"));

            //Console.WriteLine(phoneBook["Test01"]);

            //phoneBook["Test01"] = 1111;

            //Console.WriteLine(phoneBook["Test01"]);

            #endregion

            #region Class

            //Car car = new Car(3,50,"Toyta");
            //Console.WriteLine(car.ToString());

            #endregion
        }
    }
}
