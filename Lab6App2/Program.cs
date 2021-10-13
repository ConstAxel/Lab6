using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6App2
{
    class Program
    {
        static void Main(string[] args)
        {//Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
         //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
            Console.WriteLine("Введите предложение");
            string pa = Console.ReadLine();
            string[] s = pa.Split(' ');
            string pa1 = "";
            string ap = "";
            foreach (string  a in s)
            {
                pa1 += a.ToLower();
            }
            for (int i = pa1.Length-1; i >= 0; i--)//перебираем с конца
            {
                ap+= pa1[i].ToString();
            }
            if (pa1==ap)
            {
                Console.WriteLine($"Строка палиндрома:\n{pa1}\n{ap}");
            }
            else
            {
                Console.WriteLine($"Строка не палиндрома:\n{pa1}\n{ap}");
            }
            Console.ReadKey();
        }
    }
}
