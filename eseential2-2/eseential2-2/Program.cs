using System;

namespace eseential2_2
{
    class Program
    {
        static void  Main(string[] args)
        {
            Console.WriteLine("Введите курс $ :");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите курс Euro :");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите курс Rub :");
            double rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму к обмену :");
            double summaConvert = Convert.ToDouble(Console.ReadLine());

            Converter conv = new Converter(usd, euro, rub);

            Console.Clear();
            Console.WriteLine($"За {summaConvert }грн. Вы получите {conv.GrivnaToUsd(summaConvert)} $");
            Console.WriteLine($"За {summaConvert }грн. Вы получите {conv.GrivnaToEuro(summaConvert)} euros");
            Console.WriteLine($"За {summaConvert }грн. Вы получите {conv.GrivnaToRub(summaConvert)} rubs");
            Console.WriteLine($"За {summaConvert} usd Вы получите {conv.UsdToGrivna(summaConvert)} грн.");
            Console.WriteLine($"За {summaConvert} euros Вы получите {conv.EuroToGrivna(summaConvert)} грн.");
            Console.WriteLine($"За {summaConvert} rub Вы получите {conv.RubToGrivna(summaConvert)} грн.");
        }
    }
}
