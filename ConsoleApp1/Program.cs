using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a = "); //вывод строки
            double a = Convert.ToInt32(Console.ReadLine()); //ввод a
            Console.Write("Введите b = "); //вывод строки
            double b = Convert.ToInt32(Console.ReadLine()); //ввод b
            Console.Write("Введите c = "); //вывод строки
            double c = Convert.ToInt32(Console.ReadLine());  //ввод c
            if (a == 0) //проверка значения a
            {
                if (b == 0) //проверка значения b
                {
                    if (c == 0) //проверка значения c
                    {
                        Console.WriteLine("x - любое"); //вывод строки
                    }
                    else
                    {
                        Console.WriteLine("нет решения"); //вывод строки
                    }
                }
                else
                {
                    double x = -c / b; //вычисление значения x
                    Console.WriteLine($"x1 = {x}"); //вывод строки и значения x
                }
            }
            else
            {
                double D = b * b - 4 * a * c; //вычисление значения дискриминанта
                if (D > 0) //проверка значения дискриминанта
                {
                    D = Math.Sqrt(D); //вычисление квадратного корня из дискриминанта
                    double x1 = (-b - D) / (2 * a); //вычисление значения x1
                    double x2 = (-b + D) / (2 * a); //вычисление значения x2
                    Console.WriteLine($"x1 = {x1}"); //вывод строки и значения x1
                    Console.WriteLine($"x2 = {x2}"); //вывод строки и значения x2
                }
                else
                {
                    if (D == 0) //проверка значения дискриминанта
                    {
                        double x11 = -b/(2 * a); //вычисление значения x
                        Console.WriteLine($"x1 = {x11}"); //вывод строки и значения x
                    }
                    else
                    {
                        Console.WriteLine("нет решения"); //вывод строки
                    }
                }
            }
            
        }
    }
}
