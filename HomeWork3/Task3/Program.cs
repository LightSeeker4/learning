using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    // Алексей Сазонов
    //3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    //   Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    //   Написать программу, демонстрирующую все разработанные элементы класса.
    //   Добавить свойства типа int для доступа к числителю и знаменателю;
    //   Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
    //   ** Добавить проверку, чтобы знаменатель не равнялся 0. 
    //   Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
    //   *** Добавить упрощение дробей.
    class Program
    {
        static void Main(string[] args)
        {
            Fractions a = new Fractions(2,4);
            Fractions b = new Fractions(1,8);
            
            Console.WriteLine(Fractions.Sum(a, b).ToString());
            Console.WriteLine(Fractions.Diff(a, b).ToString());
            Console.WriteLine(Fractions.Multi(a, b).ToString());
            Console.WriteLine(Fractions.Div(a, b).ToString());
            Console.ReadLine();

            
        }
    }
}
