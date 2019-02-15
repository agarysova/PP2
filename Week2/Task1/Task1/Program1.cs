using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Palindrome(string s) //вводим логич значение bool, чтобы определить палиндром
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--) //пробегаемся с начала и с конца
                if (s[i] != s[j]) //если первая половина не соотвствует второй, возвращаем false, а иначе true
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine(); //вводим слово
            if (Palindrome(s)) //если соответствует условию Palindrome, выводим "Yes", иначе "No"
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}

