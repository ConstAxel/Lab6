using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6App3
{
    class Program
    {
        static void Main(string[] args)
        {//Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько фрагментов, заключённых в фигурные скобки.
         //Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
            /*Console.WriteLine("Введите строку");
            string s = "В строке может быть несколько {фрагментов} заключённых в {{фигурные}} скобки";
            char[] chars = s.ToCharArray();
            char nach = ('{');
            char konech = ('}');
            int L = 0;//интервал
            int skoba = 0;
            string newText = s;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == nach)
                {
                    skoba = i;
                }
                if (skoba == 0)
                {
                    L+= i;
                }

                if (chars[i] == konech)
                {
                    skoba = 0;
                }
            }
            Console.WriteLine(newText);
            Console.ReadKey();  */
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == '{' && s[i + 1] != '{')
                    {
                        if (s[j] == '}')
                        {
                            s = s.Substring(0, i) + s.Substring(j + 1);
                        }
                    }
                    if (s[i] == '{' && s[i + 1] == '{')
                    {
                        if (s[j] == '}')
                        {
                            s = s.Substring(0, i) + s.Substring(j + 2);
                        }
                    }

                }
                

            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
