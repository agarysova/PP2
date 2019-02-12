using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        public void PrintInfo()
        {
            Console.WriteLine(name); //Записываем заданное значение в консоль
            Console.WriteLine(id);
            Console.WriteLine(year + 1); //увеличиваем год
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); //обращаемся к классу Student
            s.name = "Togzhan"; //вводим нужные данные
            s.id = "18BD110340";
            s.year = int.Parse("2019");
            s.PrintInfo();
            Console.ReadKey();
        }
    }
}
