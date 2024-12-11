using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
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
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: return "Ошибка";

            }
        }
    }
}
