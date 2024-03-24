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
            Console.WriteLine("0-Выход");

            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 0)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            double result = 0;

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер операции. Попробуйте снова.");
                    continue;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}