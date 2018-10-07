using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            valueTypes();

            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt= " + maxInt);
            Console.WriteLine("minInt= " + minInt);
            Console.WriteLine("maxLong= " + maxLong);
            Console.WriteLine("minLong= " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zalezny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            //int age = int.Parse(Console.ReadLine());
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wypij piwo!");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wprowadziłeś zły wiek, popraw to!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wypij mleko hehe");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
