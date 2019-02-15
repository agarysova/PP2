
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level) //метод для пробелов
        {
            for (int i = 0; i < level; i++)
                Console.Write("       ");
        }
        static void FD(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles(); //получаем список файлов
            DirectoryInfo[] directories = directory.GetDirectories(); //список каталогов

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name); //записываем имя файла в консоль
            }

            foreach (DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name); //имя каталога
                FD(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Хрюшка\Desktop\textFile"); //инициализирует содержимое папки
            FD(d, 0); //начинаем с нулевого уровня
            Console.ReadKey();
        }
    }
}
