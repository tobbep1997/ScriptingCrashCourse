namespace CSharpForDummies
{
    internal class Arbetare
    {
        private const int m_minSalary = 30000;

        //Hård inkapsling

        private string m_name;
        private int m_age;
        private int m_salary;

        public int Salary
        {
            get
            {
                return this.m_salary;
            }

            set
            {
                this.m_salary = value > m_minSalary ? value : m_minSalary;
            }
        }

        public int TestInteger;


        public Arbetare() // Constructor
        {
            this.m_name = "";
            this.m_age = 0;
            this.m_salary = m_minSalary;
        }

        public Arbetare(string name, int age, int salary = m_minSalary) // Constructor
        {
            this.m_name = name;
            this.m_age = age;
            this.m_salary = salary;
            this.TestInteger = 1;
        }

        ~Arbetare() // Destructor
        {
            this.TestInteger = 0;
        }

        public int Pay(int currentMoney)
        {
            return currentMoney - this.m_salary;
        }

        public void Raise(int raise)
        {
            this.m_salary += raise;
        }

        public string GetName()
        {
            return this.m_name;
        }

        public int GetAge()
        {
            return this.m_age;
        }

        public void SetAge(int age)
        {
            this.m_age = age;
        }

        public override string ToString()
        {
            return "Name: " + this.m_name + "\nAge : " + this.m_age + "\nSalary : " + this.m_salary;
        }

        public string ToSaveString()
        {
            return this.m_name + "\n" + this.m_age + "\n" + this.m_salary;
        }
    }
}
