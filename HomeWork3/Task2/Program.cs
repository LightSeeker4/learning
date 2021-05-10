using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Алексей Сазонов
    //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //Требуется подсчитать сумму всех нечётных положительных чисел.
    //Сами числа и сумму вывести на экран, используя tryParse.

    class Program
    {
        public static int SumOddNumber()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Если хотите выйти из программы, введите 0\nВведите положительное число = ");
                int.TryParse(Console.ReadLine(), out int a);

                if (a == 0) break;
                if (a > 0 && a % 2 == 1) sum += a;
            }
            return sum;
        }

        static void Main(string[] args)
        {

          
            int x = SumOddNumber();
            Console.WriteLine($"Сумма всех введённых нечётных чисел = {x}");

          
          

        }
    }
}
