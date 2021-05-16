using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Class1
    {
        //б) ** с использованием регулярных выражений.
        static bool CheckLogin(string login)
        {
            char a = login[0];
            if (Char.IsDigit(a))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]{2,10}\b"))
                return false;
            return true;
        }


        public static void Auth()
        {
            Console.WriteLine("Вас приветствует программа проверки корректности логина.");
            int Tries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLogin(login) && CheckLogin(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Tries--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой;"
                        + "\nу вас осталось" + Tries +  "попыток;");
                }
            } while (Tries > 0);
            Console.WriteLine("Логин корректен!");
            Console.ReadKey();
        }
    }
}
