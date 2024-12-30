using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_oop_01
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;


        public long this[string name]
        {
            get 
            { 
               return GetNumber(name);    
            }

            set
            {
                UpdateNumber(name, value);
            }

        }

        public PhoneBook(int size) // ctor
        {
            names = new string[size];
            numbers = new long[size];
        }

        public void AddContact(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        public void UpdateNumber(string name, long number)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = number;
                }
            }
        }

    
    }
}