﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    //Алексей Сазонов
    //1. Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Auth();
        }
    }
}
