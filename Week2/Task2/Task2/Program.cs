using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Хрюшка\Desktop\textFile\text.txt"); //инициализирует содержимое файла
            string s = sr.ReadToEnd(); //считываем содержимое файла в стринг
            Console.WriteLine(s); //выводим на консоль

            string[] arr = s.Split(); //содержимое помещаем в массив
            string ss = "";

            for (int i = 0; i < arr.Length; i++) //пробегаемся по массиву
            {
                int n = int.Parse(arr[i]); //строковое значение числа преобразуем в числовое
                bool isPrime = true; 
                for(int j = 2; j < Math.Sqrt(n); j++) //чтобы проверить, что число простое, нужно проверить делимость от 2 до квадрата самого числа
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (n != 1 && isPrime) //если число не равно 1 и простое, записываем его, при этом конвертируя числовые значения в строковые
                {
                    ss += Convert.ToString(n) + " ";
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Хрюшка\Desktop\textFile\output.txt"); //записываем символы в поток
            sw.WriteLine(ss); //записываем простое числа в файл
            sw.Close(); //закрываем поток

            Console.ReadKey();
        }
    }
}
