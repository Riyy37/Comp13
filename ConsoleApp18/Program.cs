using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    /// <summary>
    ///  По номеру месяца вывести название времени года.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            byte month = InPut("Введите число от 1 до 12: ");
            string m = GetMonth(month);
            Console.WriteLine(m);
            Console.ReadKey();

        }
        static byte InPut(string message)
        {
            Console.Write(message);
            return byte.Parse(Console.ReadLine());
        }
        static string GetMonth(int month)
        {
            switch (month)
            {
                case 1: return "Зима";
                case 2: return "Зима";
                case 3: return "Весна";
                case 4: return "Весна";
                case 5: return "Весна";
                case 6: return "Лето";
                case 7: return "Лето";
                case 8: return "Лето";
                case 9: return "Осень";
                case 10: return "Осень";
                case 11: return "Осень";
                case 12: return "Зима";
                default: return "Ошибка";

            }
        }
    }

        
}
