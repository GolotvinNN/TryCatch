using System;

namespace FunctionCalculatorLibrary
{
    public class FunctionCalculator
    {
        public static void CalculateFunctionValues(int k, double N, int iterations)
        {
            for (double x = 0; x <= k; x += 0.1) // Итерация от 0 до k с шагом 0.1
            {
                try
                {
                    double result = CalculateFunctionValue(x, N); // Вычисление значения функции
                    Console.WriteLine($"f({x}) = {result}"); // Вывод результата функции
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"f({x}) = Бесконечность (деление на 0)"); // Вывод сообщения об ошибке деления на ноль
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"f({x}) = Ошибка: Выход за пределы диапазона."); // Вывод сообщения о выходе за пределы диапазона
                }
                catch (Exception e)
                {
                    Console.WriteLine($"f({x}) = Произошла ошибка: {e.Message}"); // Вывод общего сообщения об ошибке
                }
            }

            Console.WriteLine("Программа завершена."); // Сообщение о завершении программы
        }

        private static double CalculateFunctionValue(double x, double N)
        {
            if (Math.Abs(x - N) < double.Epsilon) // Проверка на приближение к N
            {
                throw new DivideByZeroException(); // Генерация исключения деления на ноль
            }

            if (x < 0 || x > 100) // Проверка диапазона x
            {
                throw new ArgumentOutOfRangeException(); // Генерация исключения выхода за пределы диапазона
            }

            return 1 / (x - N); // Вычисление значения функции
        }
    }
}