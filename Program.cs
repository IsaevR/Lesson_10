
/* Тестовое задание:  Написать метод Join который принимает массив строк, а возвращает
 строку сформированную по следующему алгоритму:
 1.[] => ""
 2.[] => "1"and"2"
 3.[] => "1","2","3"and"4" .........................................................*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestDev
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[0];
            string[] str1 = new[] { "1" };
            string[] str2 = new[] { "1", "2" };
            string[] str3 = new[] { "1", "2", "3", "4", "5" };

        

            Console.WriteLine(Join(str));
            Console.WriteLine(Join(str1));
            Console.WriteLine(Join(str2));
            Console.WriteLine(Join(str3));

            }

           
            static string Join(string[] str)
            {
                string comma = ", ";
                string and = " and ";

                string line = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if (i == str.Length - 2)
                        str[i] += and;

                    else if (i != str.Length - 1)
                        str[i] += comma;
                
                line += str[i];
                }
                
                return line;
            }

       

    }
}
