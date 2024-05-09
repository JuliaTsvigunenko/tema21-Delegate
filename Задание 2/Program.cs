using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {

            // присваивание адреса метода через конструктор
            Operation del = new Operation(Add); // делегат указывает на метод Add
            int result = del.Invoke(4, 2);
            Console.WriteLine(result);

            del = Sub;  // Теперь делегат указывает на метод Subtraction
            result = del(4, 2);
            Console.WriteLine(result);

            del = Mul; // Теперь делегат указывает на метод Multiplication
            result = del(4, 2);
            Console.WriteLine(result);

            del = Div;  // Теперь делегат указывает на метод Division
            result = del(4, 2);
            Console.WriteLine(result);

        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Sub(int x, int y)
        {
            return x - y;
        }

        private static int Mul(int x, int y)
        {
            return x * y;
        }

        private static int Div(int x, int y)
        {
            if(y!=0)
            return x / y;
            else
            {
                Console.WriteLine("На ноль днлить нельзя!");
                return 0; // Возвращаем 0, чтобы избежать ошибки компиляции
            }
        }



    }
}
