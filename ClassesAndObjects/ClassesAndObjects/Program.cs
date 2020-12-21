using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main()
        {
            var peter = new Person();
            peter.Name = "Пётр";
            peter.Surname = "Иванов";
            peter.Age = 17;

            var ann = new Person { Name = "Анна", Surname = "Сергеева", Age = 17 };

            Console.WriteLine(peter.GetFullName());
            peter.PrinInfo();
            ann.PrinInfo();

            ann.Surname = peter.Surname + "a";
            ann.Age = 20;
            ann.PrinInfo();


            Console.WriteLine();
            Console.WriteLine(Person.Species);
            Person.PrintSpecies(peter);

            Console.ReadKey();
        }
    }
}
