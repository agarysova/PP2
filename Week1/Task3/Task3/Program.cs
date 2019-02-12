using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nn = Console.ReadLine(); //кол-во элементов в массиве
            int n = int.Parse(nn);

            String s = Console.ReadLine(); //вводим сам массив
            String[] nums = s.Split(' '); //разбиваем элементы с помощью " "

            Triangle t = new Triangle(); //обращаемся к классу Triangle
            t.Draw(nums);
        }
    }

    public class Triangle
    {
        public void Draw(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); //вводим элементы массива
                Console.Write(array[i] + " "); //повторно вводим элементы массива
            }
            Console.ReadKey();
        }
    }
}
