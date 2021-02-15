using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        static public string Species = "Homo Sapience";

        //int inn;

        public string Name;
        public string Surname;

        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new Exception("Возраст должен быть положительным");
            }
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public void PrinInfo()
        {
            Console.WriteLine($"Имя: {Name}. Фамилия: {Surname}. Возраст: {Age}");
        }

        static public void PrintSpecies(Person person)
        {
            person.PrinInfo();
            Console.WriteLine($"Биологический вид: {Species}");
        }

    }
}
