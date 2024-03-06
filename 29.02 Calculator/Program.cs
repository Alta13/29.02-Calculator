using System;

    class Calculator
    {
        static void Main()
        {
            double num1, num2, result;
            char option;

            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие (+, -, *, /):");
        option = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (option)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Результат: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Делить на 0 нельзя!");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка! Выбрано не верное действие!");
                    break;
            }

            Console.ReadLine();
        }
    }

