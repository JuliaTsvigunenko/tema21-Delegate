using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        delegate void GetMessege(); // 1. Объявляем делегат

        static void Main(string[] args)
        {

            GetMessege del; // 2. Создаем делегат
            if (DateTime.Now.Hour<12) 
            {
                del = GM;  // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                del = GE;  // 3. Присваиваем этой переменной адрес метода
            }
            del.Invoke();  // 4. Вызываем метод
            Console.WriteLine();
        }

        private static void GM()
        {
            Console.WriteLine("Доброе утро!");
        }

        private static void GE()
        {
            Console.WriteLine("Добрый вечер!");
        }
    }
}
