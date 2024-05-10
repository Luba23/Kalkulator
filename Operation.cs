using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Operation
    {
        public abstract string Name { get; }

        public abstract double Run(params double[] numbers);
    }
    public class Addition : Operation
    {
        public override string Name => "Сложение";

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

    public class Substraction : Operation
    {
        public override string Name => "Вычитание";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public class Multiplacation : Operation
    {
        public override string Name => "Умножение";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public class Division : Operation
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
    public sealed class Cos : Operation
    {
        public override string Name => "Косинус";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public sealed class Sin : Operation
    {
        public override string Name => "Синус";

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }
}
