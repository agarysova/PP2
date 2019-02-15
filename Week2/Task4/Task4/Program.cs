using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        public static string FolderName = @"C:\Users\Хрюшка\Desktop\Новая папка\FileToCopy";
        public static string fileName = "FileToCopy.txt";

        public static void Delete(string source) //метод для удаления файла с исходного места после копирования
        {
            File.Delete(source); //удаление файла с исходного каталога
        }

        public static void Copy(string source, string dest) //метод для копирования файла с одного места в другое
        {
            File.Copy(source, dest, true); //копирование файла с одного каталога в другой
            Delete(source); //вызываем функцию delete по очереди, чтобы удалить файл с исходного каталога
        } 

        static void Main(string[] args)
        {
            string path = Path.Combine(FolderName, "From");
            string path1 = Path.Combine(FolderName, "To");
            Directory.CreateDirectory(path); //создаем каталог по указанному пути
            Directory.CreateDirectory(path1); 
            path = Path.Combine(path, fileName); //создаем путь к файлу в 1 каталоге
            path1 = Path.Combine(path1, fileName); //...во 2 каталоге

            FileInfo fi = new FileInfo(path); //используем fileinfo, чтобы проверить существует ли файл или нет

            if (!fi.Exists)
            {
                //создаем файл и вписываем текст               
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Hello World!");
                }
            }
            else
            {
                //если файл существует, выводим следующий текст
                Console.WriteLine("File already exists!"); 

            }

            Copy(path, path1); //вызываем функцию copy, после которой вызывается delete


            Console.ReadKey();
        }
    }
}