using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double one, two, result;
                
                char sign;
                Console.Write("Программа: инженерный калькулятор.\n" + 
                    "Вам необходимо ввести первое число, знак действия, которое хотите совершить," +
                    " второе число.\n");
                Console.Write("Функции калькулятора и как они обозначаются:\n умножение «*»\n" +
                    " вычитание «-»\n сложение «+»\n деление «/»\n остаток от деления «%»\n " +
                    "возведение в степень «^»\n извлечение корня «q»\n синус «s»\n " +
                    "косинус «c»\n тангенс «t»\n котангенс «g»\n подсчёт факториала «!»\n");
                Console.Write("Введите первое число: ");
                one = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите знак действия : ");
                sign = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите Второе число, если его нет, то введите «1»: ");
                two = Convert.ToDouble(Console.ReadLine());

                if (sign == '+')
                {
                    result = one + two;
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == '-')
                {
                    result = one - two;
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == '*')
                {
                    result = one * two;
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == '/')
                {
                    if (two != 0)
                    {
                        result = one / two;
                        Console.WriteLine("Ответ: " + result);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. На ноль делить нельзя!");
                        Console.ReadKey();
                    }
                }
                if (sign == '%')
                {
                    result = one % two;
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == '^')
                {
                    result = Math.Pow(one, two);
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == 'q')
                {
                    result = Math.Sqrt(one);
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                if (sign == '!')
                {
                    double Factorial(double x)
                    {
                        if (x == 1) return 1;

                        return x * Factorial(x - 1);
                    }
                    result = Factorial(one);
                    Console.WriteLine("Ответ: " + result);
                    Console.ReadKey();
                }
                Console.Write("Хотите продолжить?\nВведите [y], если да, и [n], если нет: ");
                again= Convert.ToChar(Console.ReadLine());
            }
            
        }
    }
   
}
