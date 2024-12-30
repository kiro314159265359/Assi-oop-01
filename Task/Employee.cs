using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    [Flags]
    enum privileges
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
        SecurityOfficer = 0
    }
    internal class Employee
    {
        private int id;
        private string name;
        private int securityLevel;
        private double salary;
        private Date hireDate;
        private char gender;
        private privileges securityprivileges;

        
        public Employee()
        {
            
        }
        public Employee(int id, string name, int securityLevel, double salary, string day, string month, string year, char gender, privileges privileges)
        {
            this.id = id;
            this.name = name;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = new Date(day, month, year);
            this.gender = gender;
            this.securityprivileges = privileges;
        }

        //#region Setters and Getters
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //public int GetId()
        //{
        //    return id;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return name;
        //}


        //public void SetSecurityLevel(int securityLevel)
        //{
        //    this.securityLevel = securityLevel;
        //}

        //public int GetSecurityLevel()
        //{
        //    return securityLevel;
        //}

        //public void SetSalary(double salary)
        //{
        //    this.salary = salary;
        //}

        //public double GetSalary()
        //{
        //    return this.salary;
        //}

        //public void SetHireDate(Date hireDate)
        //{
        //    this.hireDate = hireDate;
        //}

        //public Date GetHireDate()
        //{
        //    return hireDate;
        //}

        //public void SetGender(char gender)
        //{
        //    if (gender == 'F' || gender == 'M')
        //    {
        //        this.gender = gender;
        //    }

        //}

        //public char GetGender()
        //{
        //    return gender;
        //}

        //public void SetSecurityPrivileges(privileges privileges)
        //{
        //    this.securityprivileges = privileges;
        //}

        //public privileges GetSecurityPrivileges()
        //{
        //    return securityprivileges;
        //} 
        //#endregion

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Date HireDate
        {
            get { return hireDate; }
        }

        public char Gender
        {
            set
            {
                if(gender == 'F' || gender == 'M')
                    gender = value;
            }
            get
            {
                return gender;
            }
        }
        public int SecurityLevel
        {
            set { securityLevel = value; }
            get { return securityLevel; }
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public privileges Securityprivileges
        {
            get { return securityprivileges; }
            set { securityprivileges = value; }
        }


        public override string ToString()
        {
            return $"Employee ID: {id}, Name: {name}, Security Level: {securityLevel}, " +
                   $"Salary: {salary:C}, Hire Date: {hireDate}, Gender: {gender}, " +
                   $"Privileges: {Securityprivileges}";
        }

    }
}
