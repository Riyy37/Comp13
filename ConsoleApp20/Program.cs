using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        /// <summary>
        /// Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. 
        /// Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите первую букву: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (letter)
            {
                case 'a':
                    Console.WriteLine("автомобиль, максимальная скорость = 508,73 км/ч");
                    break;
                case 'в':
                    Console.WriteLine("велосипед, максимальная скорость = 295,6 км/ч");
                    break;
                case 'м':
                    Console.WriteLine("мотоцикл, максимальная скорость = 200 км/ч");
                    break;
                case 'с':
                    Console.WriteLine("самолёт, максимальная скорость = 8200,8 км/ч ");
                    break;
                case 'п':
                    Console.WriteLine("поезд, максмальная скорость = 574,8 км/ч");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
            Console.ReadKey();
        }
    }
}
