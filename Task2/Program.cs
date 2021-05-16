using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    //Алексей Сазонов
//2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.
//   В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
//   Здесь требуется использовать класс Dictionary.
    class Program
    {
        static void Main(string[] args)
        {
           string tttext = @"orj sgna; irtjhir три игорь пятть чтре 888 33434347 gertge80 4hr uu";
           Message.Words(tttext,3);
           Message.DeleteWords(tttext,'ь');
           Message.LongWordsString(tttext);
        }
    }
}