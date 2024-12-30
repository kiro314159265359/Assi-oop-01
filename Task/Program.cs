using Microsoft.Win32.SafeHandles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //try
            //{
            //    int XPoint1;
            //    Console.WriteLine("Enter X for the first point:");
            //    while (!int.TryParse(Console.ReadLine(), out XPoint1))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }
            //    int YPoint1;
            //    Console.WriteLine("Enter Y for the first point:");
            //    while (!int.TryParse(Console.ReadLine(), out YPoint1))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }

            //    int XPoint2;
            //    Console.WriteLine("Enter X for the second point:");
            //    while (!int.TryParse(Console.ReadLine(), out XPoint2))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }
            //    int YPoint2;
            //    Console.WriteLine("Enter Y for the second point:");
            //    while (!int.TryParse(Console.ReadLine(), out YPoint2))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }

            //    Point point1 = new Point(XPoint1, YPoint1);
            //    Point point2 = new Point(XPoint2, YPoint2);

            //    Console.WriteLine(point1.Distance(point1, point2));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Q2
            //Console.Write("Enter First person Name :");
            //string person1 = Console.ReadLine();

            //int age1;
            //Console.Write("Enter First person age:");
            //while (!int.TryParse(Console.ReadLine(), out age1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer:");
            //}
            //Console.Write("Enter second person Name :");
            //string person2 = Console.ReadLine();

            //int age2;
            //Console.Write("Enter second person age :");
            //while (!int.TryParse(Console.ReadLine(), out age2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer:");
            //}
            //Console.Write("Enter Third person Name :");
            //string person3 = Console.ReadLine();
            //int age3;
            //Console.WriteLine("Enter Third person age: ");
            //while (!int.TryParse(Console.ReadLine(), out age3))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer:");
            //}


            //Person[] people = new Person[3];
            //Person One = new Person(person1, age1);

            //Person Two = new Person(person2, age2);

            //Person Three = new Person(person3, age3);

            //people[0] = One;
            //people[1] = Two;
            //people[2] = Three;

            //int maxAge = Math.Max(people[0].Age, Math.Max(people[1].Age, people[2].Age));
            //for (int i = 0; i < people.Length; i++)
            //{
            //    if (people[i].Age == maxAge)
            //    {
            //        Console.WriteLine($"Person name is {people[i].Name} , Age is {people[i].Age}");
            //    }
            //}

            #endregion

            #region Q3
            // Created a Class employee
            //Employee emp = new Employee(1, "John Doe", 5, 50000, "15", "06", "2020", 'M');
            #endregion

            #region Q4
            Employee[] employees = new Employee[3];

            privileges securityOfficerPrivileges = privileges.SecurityOfficer;


            securityOfficerPrivileges ^= privileges.guest;
            securityOfficerPrivileges ^= privileges.Developer;
            securityOfficerPrivileges ^= privileges.secretary;
            securityOfficerPrivileges ^= privileges.DBA;

            employees[0] = new Employee(1, "Alice", 5, 70000, "01", "01", "2015", 'F', privileges.DBA);
            employees[1] = new Employee(2, "Bob", 2, 30000, "01", "01", "2020", 'M', privileges.guest);
            employees[2] = new Employee(3, "Charlie", 10, 90000, "01", "01", "2010", 'M', securityOfficerPrivileges);

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
            BubbleSort(employees);

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }

        public static void BubbleSort(Employee[] employees)
        {
            int n = employees.Length;
            Employee temp;

            // Bubble Sort Logic
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // here we are Boxing converting Date to DateTime
                    DateTime hireDate1 = employees[j].HireDate.ToDateTime();
                    DateTime hireDate2 = employees[j + 1].HireDate.ToDateTime();

                   // here unboxing heppend where DateTime values are compared
                    if (hireDate1.CompareTo(hireDate2) > 0)
                    {
                        temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }
        }


        #endregion
    }
}

