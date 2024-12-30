using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_oop_01
{

    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;
        // Address
        public int Id
        {
            //set { id = value; } read only
            get { return id; }
        }

        public string Name
        {
            set
            { 
              if (value.Length > 0)
                name = value;
            }
            get { return name; }
        }

        public double Salary
        {
            set 
            {
                if (value > 0)
                    salary = value;
            }
            get { return salary; }
        }


        public string Address
        {
            set;get;
        }
        #region Getters And Setters
        //public void SetId(int id)
        //{
        //    if (id > 0) { this.id = id; }       
        //}
        //public void SetName(string name)
        //{
        //    if(name.Length > 3)
        //        this.name = name;       
        //}
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0) 
        //        this.salary = salary;
        //}

        //public int Getid()
        //{
        //    return id;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public double GetSalary()
        //{
        //    return salary;
        //}

        //public Employee(int id , string name , double salary)
        //{
        //    SetId(id);
        //    this.name = name;
        //    this.salary = salary;
        //} 
        #endregion
    }

}