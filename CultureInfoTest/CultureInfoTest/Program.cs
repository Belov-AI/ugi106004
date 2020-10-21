using System;
using System.Globalization;

namespace CultureInfoTest
{
    class Program
    {
        static void Main()
        {
            TestCulture(CultureInfo.CurrentCulture.Name);
            TestCulture("en-GB");
            TestCulture("fr-Lu");
            TestCulture("en-US");
            TestCulture("");
            TestCulture("bg");
            TestCulture(CultureInfo.CurrentCulture.Name);

            foreach(var culture in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
                Console.WriteLine($"{culture.Name} — {culture.DisplayName}");

            Console.ReadKey();
        }

        private static void TestCulture(string ciName)
        {
            var oldCulture = CultureInfo.CurrentCulture;
            var newCulture = new CultureInfo(ciName);
            CultureInfo.CurrentCulture = newCulture;
            
            Console.WriteLine($"{newCulture.Name} — {newCulture.DisplayName}");
            Console.WriteLine(2.5);
            var dt = DateTime.Now;
            Console.WriteLine($"{dt:D} {dt:ddd}");
            Console.WriteLine();
            CultureInfo.CurrentCulture = oldCulture;
        }
    }
}
