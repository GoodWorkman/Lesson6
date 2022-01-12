/*
 * Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double).
   Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)
Anton Manakov
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson6Homework
{
    


    class Program
    {

        public static void Table(fun1 F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        static void Main()
        {

            Console.WriteLine("Таблица функции MyFunc1:");
            Table(new fun1(MyFunc1), -2, 2);
            Console.WriteLine("Таблица функции MyFunc2:");
            Table(new fun1(MyFunc2), -2, 2);

        }

        public delegate double fun1(double a, double x);
        public static double MyFunc1(double a, double x)
        {
            return a * x * x;
        }
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }

    }

}
