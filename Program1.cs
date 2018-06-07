// Тестовое задание 2: Написать метод который переворачивает слова в тексте, но не меняет знаки
// препинания и другие буквенные последовательности, например:
// “text_one_123_two” => “txet_eno_123_owt
using System;
using System.Collections.Generic;

namespace TestDev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "text_one_123_two_wft";

            Console.Write("Исходная строка - {0}\n", line);
            Console.Write("Перевернутая строка - " + RevString(line));
            
            Console.ReadLine();
        }

        static string RevString(string s)
        {

            string buff = "";

            string str = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))         ///* Char.IsLetter (char) - этот метод определяет,  
                {                                /// является ли Char членом какой-либо
                    buff = s[i] + buff;          ///категории букв Юникода.
                }                                ///возвращаемое значение - true/false.*/
                else
                {
                    str += buff;
                    buff = "";
                    str += s[i];
                }
            }

            if (!string.IsNullOrEmpty(buff)) // Указывает, является ли указанная строка строкой null или Empty. 
            {
                str += buff;
            }

            return str;
            
        }

    }
}
