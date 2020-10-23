using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Employee
{
    class Employee
    {
        private string name, surename, jobRole, jobrole;
        private double salary;
        public Employee()
        {
        }
        public Employee(string name, string surename)
        {
            this.name = name;
            this.surename = surename;
        }
        public double Taxes(double salary)
        {
            double taxes = 0;

            if (salary < 1200) taxes = 0;
            if (salary > 1200 && salary < 2500) taxes = salary * 0.1;
            if (salary > 2500 && salary < 5000) taxes = salary * 0.2;
            if (salary > 5000) taxes = salary * 0.3;
            return (taxes);
        }
        public string Jobrole
        {
            get { return jobrole; }
            set { jobrole = value; }
        }
        public void Salary(string jobrole, int workexpirience)
        {
            double salary = 0;

            switch (jobrole)
            {
                case "manager":
                    salary = 5000 + 5000 * (workexpirience * 0.05);
                    break;
                case "assistant":
                    salary = 1500 + 1500 * ((workexpirience * 0.03));
                    break;

                case "hr":
                    salary = 2500 + 2500 * ((workexpirience * 0.04));
                    break;
            }
            if (salary != 0)
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine } Зарплатная ведомость {Environment.NewLine }");
                Console.WriteLine($"*********************************{Environment.NewLine }");
                Console.WriteLine($" {name} {surename} {Environment.NewLine }---------------------------------{Environment.NewLine } Должность    : {jobrole}{Environment.NewLine } Зарплата     : {salary}");
                Console.WriteLine($" Налог        : {Taxes(salary)}");
                Console.WriteLine($" К выдаче     : {salary - Taxes(salary)}");
                Console.WriteLine($"{Environment.NewLine }*********************************{Environment.NewLine }");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Нет такой должности");
            }
        }
    }
}