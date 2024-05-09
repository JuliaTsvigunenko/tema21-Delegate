using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        delegate double Average(int m, int n);

        static void Main(string[] args)
        {

            // Присваивание адреса метода через конструктор
            Average del = new Average(Average1); // делегат указывает на метод Average1
            double result = del.Invoke(1, 10);
            Console.WriteLine($"Среднее арифметическое от 1 до 10: {result} ");

            del = Average1; // Теперь делегат указывает на метод Average1
            result = del(10, 20);
            Console.WriteLine($"Среднее арифметическое от 10 до 20: {result} ");

            del = Average1; // Теперь делегат указывает на метод Average1
            result = del(20, 30);
            Console.WriteLine($"Среднее арифметическое от 20 до 30: {result} ");

        }

        // Объявляем статический метод для вычисления среднего арифметического
        private static double Average1(int m, int n)
        {
            double sum = 0; // Инициализируем переменную для хранения суммы всех чисел в заданном диапазоне
            for (int i = m; i <= n; i++) // Проходим по всем числам от m до n включительно
            {
                sum += i; // На каждой итерации добавляем текущее число к сумме
            }
            return sum / (n - m + 1); // Вычисляем среднее арифметическое суммы чисел в диапазоне, разделив сумму на количество чисел в диапазоне (n - m + 1)
        }


    }
}
