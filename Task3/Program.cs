using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //Алексей Сазонов
    //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //Например: badc являются перестановкой abcd
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.Check("cbda","abcd"));
        }
    }
}