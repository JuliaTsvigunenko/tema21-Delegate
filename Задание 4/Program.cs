using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate int Sum(int m, int n);

        static void Main(string[] args)
        {
            // Создаем экземпляр делегата
            Sum del = new Sum(Sum1);

            // Применяем созданный делегат три раза

            int result1 = del.Invoke(1, 10); // Сокращенный синтаксис вызова делегата
            Console.WriteLine($"Сумма от 1 до 10: {result1}");

            del = Sum1;
            int result2 = del.Invoke(10, 20); // Сокращенный синтаксис вызова делегата
            Console.WriteLine($"Сумма от 10 до 20: {result2}");

            del = Sum1;
            int result3 = del.Invoke(20, 30); // Сокращенный синтаксис вызова делегата
            Console.WriteLine($"Сумма от 20 до 30: {result3}");

        }

        public static int Sum1(int m, int n)
        {
            int sum = 0;
            for (int i=m; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
