using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение k: ");
            int k = int.Parse(Console.ReadLine()); // Ввод значения k

            Console.Write("Введите значение N: ");
            double N = double.Parse(Console.ReadLine()); // Ввод значения N

            Console.Write("Введите количество итераций: ");
            int iterations = int.Parse(Console.ReadLine()); // Ввод количества итераций

            FunctionCalculatorLibrary.FunctionCalculator.CalculateFunctionValues(k, N, iterations); // Вызов метода для вычисления функции

            Console.WriteLine("Нажмите любую клавишу для выхода..."); // Подсказка для завершения программы
            Console.ReadKey(); // Ожидание нажатия любой клавиши пользователем
        }
    }
}







