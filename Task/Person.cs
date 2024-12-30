using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Person
    {
        private string name;

        public Person(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { 
                if(value.Length > 0)
                    name = value;     
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { 
                if(age > 0 && age < 99)
                    age = value;
            }
        }



    }
}
