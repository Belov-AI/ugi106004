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

            var file = new FileInfo("test.txt");

            Console.WriteLine(file.Name);
            Console.WriteLine(file.FullName);

            using (var stream = new StreamWriter("test.txt", true))
            {
                Console.WriteLine("Введите текст построчно (Enter - конец ввода)");

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == string.Empty)
                        break;

                    stream.WriteLine(input);
                }
            }

            using (var stream = new StreamReader("test.txt"))
            {
                while (!stream.EndOfStream)
                {
                    Console.WriteLine(stream.ReadLine());
                }
            }

            var listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory());

            Console.WriteLine();

            foreach (var fileName in listOfFiles)
                Console.WriteLine(fileName.Substring(fileName.LastIndexOf('\\') + 1));

            var current = new DirectoryInfo(".");
            Console.WriteLine(current.Name);

            Console.ReadKey();
        }
    }
}
