using System;

namespace Essential1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите длинну");
            double wide = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Введите ширину");
            double high = Convert.ToDouble(Console.ReadLine());
                    
            Rectangle inst = new Rectangle (wide, high);
            double perimetr = inst.Perimetr;
            double area = inst.Area;

            Console.WriteLine($"area= {area} perimetr = { perimetr}");
        }
    }
}
