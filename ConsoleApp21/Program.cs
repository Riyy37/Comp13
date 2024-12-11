using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    /// <summary>
    /// Дан признак геометрической фигуры на плоскости: 
    /// к – круг, п – прямоугольник, т - треугольник. 
    /// Вывести на экран периметр и площадь заданной фигуры 
    /// (данные, необходимые для расчетов, запросить у пользователя).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую букву: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            

            switch (letter)
            {
                case 'к':
                    Console.WriteLine("круг");
                    Console.Write("Введите радиус = ");
                    int r = int.Parse(Console.ReadLine());
                    double c1 = 2 * Math.PI * r;
                    Console.WriteLine($"Периметр = {c1:F2}");
                    double s = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"Площадь = {s:F2}");
                    break;
                case 'п':
                    Console.WriteLine("прямоугольник");
                    Console.Write("Напишите сторону 1 = ");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.Write("Напишите сторону 2 = ");
                    int side2 = int.Parse(Console.ReadLine());
                   
                    double s1 = (side1 * side2);
                    double p = 2*(side1+ side2);
                    Console.WriteLine($"Периметр = {p:F2}");
                    Console.WriteLine($"Площадь = {s1:F2}");
                    break;
                case 'т':
                    Console.WriteLine("треугольник");
                    Console.Write("Введите сторону 1 = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введите сторону 3 = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Высоту = ");
                    int h = int.Parse(Console.ReadLine());
                    Console.Write("Введите сторону 3 = ");
                    int c = int.Parse(Console.ReadLine());
                    int p1 = a + b + c;
                    int s2 = (a + h) / 2;
                    Console.WriteLine($"Периметр = {p1}");
                    Console.WriteLine($"Площадь = {s2}");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
            


            Console.ReadKey();

        }
    }
}
