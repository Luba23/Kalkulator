using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Application
    {
        public void Run()
        {
        }
    }
    public class Program
    {
        public static void Menu(Operation[] operations)
        {
            
            {
                Console.WriteLine("Программа: инженерный калькулятор.\n" + 
                    "Вам необходимо ввести первое число, знак действия, которое хотите совершить," +
                    " второе число.\n");
                for (int i = 0; i < operations.Length; i++)
                {
                    Operation operation = operations[i];
                    Console.WriteLine($"{i + 1}. {operation.Name}");
                }
                
                
            }
            
        }
    }
    public static void Main()
    {
        try
        {
            
        }
        catch ()
        {
 
        }
    }
    public abstract class Operation
    {
        public abstract string Name { get; }

        public abstract double Run(params double[] numbers);
    }
    public sealed class Addition : Operation
    {
        public override string Name => "Сложение";

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }
    public sealed class Substraction : Operation
    {
        public override string Name => "Вычитание";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }
    public sealed class Multiplacation : Operation
    {
        public override string Name => "Умножение";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }
    public sealed class Division : Operation
    {
        public override string Name => "Деление";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }
    public sealed class Sqrt : Operation
    {
        public override string Name => "Квадратный корень";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }
    class ProcessCalculation
    {
        public static void TextLines()
    {
        Console.WriteLine("функции калькулятора и как они обозначаются:\n умножение «*»\n" +
                           " вычитание «-»\n сложение «+»\n деление «/»\n остаток от деления «%»\n " +
                            "возведение в степень «^»\n извлечение корня «q»\n синус «s»\n " +
                            "косинус «c»\n тангенс «t»\n котангенс «g»\n подсчёт факториала «!»\n"); 
    }

        public static void UserInput()
        {
            Console.WriteLine("\n введите первое число: ");
            double numFirst = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n введите знак действия : ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n введите второе число: ");
            double numSecond = Convert.ToDouble(Console.ReadLine());
           
        }
    }
    //char again = 'y';
    //            while (again == 'y')
    //        double one, two, result;

    //                char sign;
    //    console.write("функции калькулятора и как они обозначаются:\n умножение «*»\n" +
    //                    " вычитание «-»\n сложение «+»\n деление «/»\n остаток от деления «%»\n " +
    //                    "возведение в степень «^»\n извлечение корня «q»\n синус «s»\n " +
    //                    "косинус «c»\n тангенс «t»\n котангенс «g»\n подсчёт факториала «!»\n");
    //   console.write("введите первое число: ");
    //                one = convert.todouble(console.readline());
    //                console.write("введите знак действия : ");
    //                sign = convert.tochar(console.readline());
    //                console.write("введите второе число, если его нет, то введите «1»: ");
    //                two = convert.todouble(console.readline());

    //                if (sign == '+')
    //                {
    //                    result = one + two;
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == '-')
    //                {
    //                    result = one - two;
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == '*')
    //                {
    //                    result = one * two;
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == '/')
    //                {
    //                    if (two != 0)
    //                    {
    //                        result = one / two;
    //                        console.writeline("ответ: " + result);
    //                        console.readkey();
    //                    }
    //                    else
    //                    {
    //                        console.writeline("ошибка. на ноль делить нельзя!");
    //                        console.readkey();
    //                    }
    //                }
    //                if (sign == '%')
    //                {
    //                    result = one % two;
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == '^')
    //                {
    //                    result = math.pow(one, two);
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == 'q')
    //                {
    //                    result = math.sqrt(one);
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                if (sign == '!')
    //                {
    //                    double factorial(double x)
    //                    {
    //                        if (x == 1) return 1;

    //                        return x * factorial(x - 1);
    //                    }
    //                    result = factorial(one);
    //                    console.writeline("ответ: " + result);
    //                    console.readkey();
    //                }
    //                console.write("хотите продолжить?\nвведите [y], если да, и [n], если нет: ");
    //                again= convert.tochar(console.readline());
}

