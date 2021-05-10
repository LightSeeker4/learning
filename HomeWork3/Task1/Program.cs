using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
       //Алексей Сазонов
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
        //Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
        //Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    class Program
    { 
        static void Main(string[] args)
        {
            Complex z1 = new Complex(125, 30);
            Complex z2 = new Complex(143, 53);
            Complex result = new Complex();

            Console.WriteLine("Выберите операцию и введите символ: +  -  *");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+": result = Complex.Sum(z1, z2); break;
                case "-": result = Complex.Diff(z1, z2); break;
                case "*": result = Complex.Div(z1, z2); break;
                default: Console.WriteLine("Такой операции нет"); break;
            }

            result.Print();
        }
    }
}

    