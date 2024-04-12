using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1-Сложение чисел");
            Console.WriteLine("2-Вычитание чисел");
            Console.WriteLine("3-Умножение чисел");
            Console.WriteLine("4-Деление чисел");
            Console.WriteLine("5-Возведение числа в степень");
            Console.WriteLine("6-Извлечение квадратного корня из числа");
            Console.WriteLine("7-Синус");
            Console.WriteLine("8-Косинус");
            Console.WriteLine("9-Тангенс");
            Console.WriteLine("10-Котангенс");
            Console.WriteLine("11-Натуральный логарифм (ln)");
            Console.WriteLine("12-Десятичный логарифм (log10)");
            Console.WriteLine("0-Выход");

            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 0)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            double result = 0;
            double num1, num2; 

            switch (operation)
            {
                case 1:
                    Addition.Add();
                    break;
                case 2:
                    Subtraction.Subtract();
                    break;
                case 3:
                    Multiplication.Multiply();
                    break;
                case 4:
                    Division.Divide();
                    break;
                case 5:
                    Power.RaiseToPower();
                    break;
                case 6:
                    SquareRoot.Sqrt();
                    break;
                case 7:
                    Trigonometry.Sin();
                    break;
                case 8:
                    Trigonometry.Cos();
                    break;
                case 9:
                    Trigonometry.Tan();
                    break;
                case 10:
                    Trigonometry.Cotan();
                    break;
                case 11:
                    Logarithm.NaturalLogarithm();
                    break;
                case 12:
                    Logarithm.DecimalLogarithm();
                    break;
                default:
                    Console.WriteLine("Неверный номер операции. Попробуйте снова.");
                    continue;
            }
        }
    }
}

class Addition
{
    public static void Add()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 + num2;
        Console.WriteLine("Результат: " + result);
    }
}

class Subtraction
{
    public static void Subtract()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 - num2;
        Console.WriteLine("Результат: " + result);
    }
}

class Multiplication
{
    public static void Multiply()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num1 * num2;
        Console.WriteLine("Результат: " + result);
    }
}

class Division
{
    public static void Divide()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        if (num2 != 0)
        {
            double result = num1 / num2;
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }
    }
}

class Power
{
    public static void RaiseToPower()
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(num1, num2);
        Console.WriteLine("Результат: " + result);
    }
}

class SquareRoot
{
    public static void Sqrt()
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Sqrt(num1);
        Console.WriteLine("Результат: " + result);
    }
}

class Trigonometry
{
    public static void Sin()
    {
        Console.WriteLine("Введите число (в радианах):");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Sin(num1);
        Console.WriteLine("Результат: " + result);
    }

    public static void Cos()
    {
        Console.WriteLine("Введите число (в радианах):");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Cos(num1);
        Console.WriteLine("Результат: " + result);
    }

    public static void Tan()
    {
        Console.WriteLine("Введите число (в радианах):");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Tan(num1);
        Console.WriteLine("Результат: " + result);
    }

    public static void Cotan()
    {
        Console.WriteLine("Введите число (в радианах):");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = 1 / Math.Tan(num1);
        Console.WriteLine("Результат: " + result);
    }
}

class Logarithm
{
    public static void NaturalLogarithm()
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Log(num1);
        Console.WriteLine("Результат: " + result);
    }

    public static void DecimalLogarithm()
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = Math.Log10(num1);
        Console.WriteLine("Результат: " + result);
    }
}
