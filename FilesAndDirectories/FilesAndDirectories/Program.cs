using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("test.txt"))
                File.Create("test.txt").Close();

            File.WriteAllText("test.txt", "Привет, мир!");
            File.AppendAllText("test.txt", "\nHello, world!");

            var text = File.ReadAllText("test.txt");
            //Console.WriteLine(text);

            var str = new[] { "", "Первая строка", "Вторая строка", "Третья строка" };
            File.AppendAllLines("test.txt", str);

            text = File.ReadAllText("test.txt");
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
