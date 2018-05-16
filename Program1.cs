// Тестовое задание 2: Написать метод который переворачивает слова в тексте, но не меняет знаки
// препинания и другие буквенные последовательности, например:
// “text_one_123_two” => “txet_eno_123_owt
using System;

namespace TestDev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "text_one_123_two";

            Console.Write("Исходная строка - {0}\n", line);
            Console.Write("Перевернутая строка - ");
            RevString(line);

        }

        static void RevString(string s)
        {
           
            char[] arr = s.ToCharArray();
            
            s = "";
            string c = "";

            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] == 95 || (arr[i] > 47 || arr[i] < 58))
                {
                    for (int j = s.Length- 1; j == 0; j--)
                    {
                       c += s[j];
                    }
               
                s = "";

                }
                s += arr[i];
                
            }
           
            Console.WriteLine(c);
            
        }
    }
}
