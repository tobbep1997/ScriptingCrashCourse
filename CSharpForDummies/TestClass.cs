using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForDummies
{
    

    class Arbetare
    {
        const int minSalary = 30000;

        //Hård inkapsling

        private string name;
        private int age;
        private int salary;

        public int Salary 
        { 
            get { return salary; } 
            set { salary = value > minSalary ? value : minSalary; } 
        }

        public int testInteger;


        public Arbetare() // Constructor
        {
            name = "";
            age = 0;
            salary = minSalary;
        }

        public Arbetare(string name, int age, int salary = minSalary) // Constructor
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            testInteger = 1;
        }

        ~Arbetare() // Destructor
        {
            testInteger = 0;
        }

        public int Pay(int currentMoney)
        {
            return currentMoney - salary;
        }

        public void Raise(int raise)
        {
            salary += raise;
        }

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }



        public string ToString()
        {
            return "Name: " + name + "\nAge : " + age + "\nSalary : " + salary; 
        }

    }
}
