using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Дано целое число n, указывающее номер дня недели от 1 до 7. 
    /// По указанному номеру n вывести название соответствующего дня недели.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            byte day = InPut("Введите число от 1 до 7: ");
            string d = GetDay(day);
            Console.WriteLine(d);
            Console.ReadKey();
            
            
        }
        static byte InPut(string message)
        {
            Console.Write(message);
            return byte.Parse(Console.ReadLine ());
        }
        static string GetDay(int day)
        {
            switch (day)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Ошибка";
                 
            }
        }
                
        
    }
}
