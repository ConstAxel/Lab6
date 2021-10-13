using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
            /*Console.WriteLine("Введите предложение");
            string p = Console.ReadLine();
            string[] s = p.Split(' ');
            int max = 0;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max)
                {
                    max = s[i].Length;
                    index = i;
                }
            }
            Console.WriteLine($"Самое длинное слово: {s[index]}:\t{max}");
            Console.ReadKey();*/

            /*Console.WriteLine("Введите предложение");
            string p = Console.ReadLine();
            string[] s = p.Split(' ');
            string max = "";
            foreach (string a in s)
            {
                if (max.Length < a.Length)
                {
                    max = a;
                }
            }
            Console.WriteLine($"Самое длинное слово: {max}");
            Console.ReadKey();*/
            Console.WriteLine("Введите предложение");
            string p = Console.ReadLine();
            string[] s = p.Split(' ');
            int max = 0;
            string maxWord = "";
            foreach (string a in s)
            {
                int word = a.Length;
                if (max < word)
                {
                    max = word;
                    maxWord = a;
                }
                else
                {
                    if (max == word)
                    {
                        max = word;
                        maxWord += ", "+a;
                    }
                }
            }
            Console.WriteLine($"Самые длинные слова:\n{maxWord}");
            Console.ReadKey(); 
        }
    }
}
