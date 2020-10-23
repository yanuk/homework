using System;
using System.Data.SqlTypes;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surename, jobrole;
            int workexpirience;

            Console.Clear();
            Console.WriteLine("Введите Имя : ");

            name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию: ");

            surename = Console.ReadLine();

            Console.WriteLine("Введите должность (manger/assistant/hr)");
            jobrole = Console.ReadLine();

            Console.WriteLine("Введите стаж работы : ");
            workexpirience = Convert.ToInt32(Console.ReadLine());

            Employee sal = new Employee(name, surename);
            {
                sal.Salary(jobrole, workexpirience);
            }
        }
    }
}