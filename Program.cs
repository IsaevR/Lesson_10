
/* Тестовое задание:  Написать метод Join который принимает массив строк, а возвращает
 строку свормированную по следующему алгоритму:
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
            string[] str = new[] { "" };
            string[] str1 = new[] { "1" };
            string[] str2 = new[] { "1", "2" };
            string[] str3 = new[] { "1", "2", "3", "4" , "5"};

            string[] s = new string[str.Length];

            s = Join(str);
            foreach (string word in s)
                Console.Write(word);
            Console.WriteLine();

            s = Join(str1);
            foreach (string word in s)
                Console.Write(word);
            Console.WriteLine();

            s = Join(str2);
            foreach (string word in s)
                Console.Write(word);
            Console.WriteLine();

            s = Join(str3);
            foreach (string word in s)
                Console.Write(word);
            Console.WriteLine("\n\n\n\n\n");




            List<string> w = new List<string>();
            
            w = Join1(str);
            foreach (string q in w)   
                Console.Write("{0}", q);
            Console.WriteLine();

            w = Join1(str1);
            foreach (string q in w)
                Console.Write("{0}", q);
            Console.WriteLine();

            w = Join1(str2);
            foreach (string q in w)
                Console.Write("{0}", q);
            Console.WriteLine();

            w = Join1(str3);
            foreach (string q in w)
                Console.Write("{0}", q);
            Console.WriteLine();
        }

        // первый способ с примменением массивов 
        static string[] Join (string[]str)
        {
            string comma = ", ";
            string and = " and ";
           
            string[] line = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 2)                  
                    str[i] += and;
                    
                else if(i != str.Length - 1)
                    str[i] += comma; 

                line[i] = str[i];   
            }

            return line;
        }

        // второй способ с применением коллекций
        
        static List<string> Join1(string[] s)
        {
            s.ToList();
            s.Append(" and ");

            return s.ToList();
        }

    }
}
