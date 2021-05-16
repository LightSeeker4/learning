using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    static class Message
    {
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        public static void Words(string text, int n)
        {
            string pattern = @"\b.{" + n + "}\\s";
            Regex regex = new Regex(pattern);
            Console.WriteLine($"{regex.IsMatch(text)}\nCлова, которые содержат не более {n} букв:");
            var col = regex.Matches(text);
            foreach (var item in col) { Console.Write(item); }
        }

        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static void DeleteWords(string text, char n)
        {
            string pattern = @"\w+?(" + n + @")(?=[\.\,\s]{1,})";
            Regex rgx = new Regex(pattern);
            StringBuilder result = new StringBuilder(rgx.Replace(text, ""));
            Console.WriteLine($"\n\nУдалить слова с символом {n} на конце:\nДо: {text}\nПосле: {result}\n");
        }

        ////в) Найти самое длинное слово сообщения.
        static public string LongWord(string text)
        {
            string[] words = text.Split(new Char[] { ' ', '.', ',', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            Console.WriteLine($"Самое длинное слово: {maxWord}");
            return maxWord;
        }

        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        static public StringBuilder LongWordsString(string text)
        {
            string[] words = text.Split(new Char[] { ' ', '.', ',', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.LongWord(text).Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            Console.WriteLine($"Строчка из самых длинных слов: {result}");
            return result;

        }
    }
}