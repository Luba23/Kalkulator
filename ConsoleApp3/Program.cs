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
            float one, two, result;
            char sign;
            Console.Write("Программа: инженерный калькулятор." +
                " Вам необходимо ввести первое число, знак действия, которое хотите совершить," +
                " второе число.\n");
            Console.Write("Функции калькулятора и как они обозначаются:\nумножение «*»\n" +
                " вычитание «-»\n сложение «+»\n деление «/»\n остаток от деления «%»\n " +
                "возведение в степень «^»\n извлечение корня «sqrt»\n синус «sin»\n " +
                "косинус «cos»\n тангенс «tg»\n котангенс «ctg»\n подсчёт факториала «!»\n");
            Console.Write("Введите первое число: ");
            one = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак действия : ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите Второе число: ");
            two = Convert.ToSingle(Console.ReadLine());

        }
    }
}
