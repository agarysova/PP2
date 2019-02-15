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
            StreamReader sr = new StreamReader(@"C:\Users\Хрюшка\Desktop\textFile\text.txt");
            string s = sr.ReadToEnd();
            Console.WriteLine(s);

            string[] arr = s.Split();
            string ss = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int n = int.Parse(arr[i]);
                bool isPrime = true;
                for(int j = 2; j < Math.Sqrt(n); j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (n != 1 && isPrime)
                {
                    ss += Convert.ToString(n) + " ";
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Хрюшка\Desktop\textFile\output.txt");
            sw.WriteLine(ss);
            sw.Close();

            Console.ReadKey();
        }
    }
}
