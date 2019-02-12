using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string starrr = Console.ReadLine(); //вводим размерность
            int star = int.Parse(starrr); //переводим string в int

            for (int i = 0; i <= star; i++) //пробегаемся по строкам
            {
                for (int j = 0; j < i; j++) //пробегаемся по столбцам
                {
                    Console.Write("[*]");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
