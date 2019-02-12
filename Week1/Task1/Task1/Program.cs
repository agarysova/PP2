using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Isprime(int n) //Задаем значение bool
        {
            int cnt = 0; //счетчик
            for (int i = 1;i <= n; i++)
            {
                if (n % i == 0) //проверяем сколько делителей имеет число
                    cnt++;
            }
            if (cnt == 2) //простое число имеет только два делителя - это 1 и само число
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            String a = Console.ReadLine(); //кол-во элементов в массиве
            int aa = int.Parse(a);

            var primes = new List<int>(); //создаем список

            String b = Console.ReadLine(); //вводим массив
            String[] nums = b.Split(' ');

            for (int i = 0; i < aa; i++)
            {
                int numm = int.Parse(nums[i]); //элементы массива превращаем в int
                if (Isprime(numm))
                {
                    primes.Add(numm); //если число соответствует усл-ю Isprime, добавляем его в Список
                }
            }

            Console.WriteLine(primes.Count); //выводим кол-во элементов со Списка
            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + " "); //выводим все элементы Списка
            }
            Console.ReadKey();
        }
    }
}
