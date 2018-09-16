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
            //string name = args[0];
            //Console.WriteLine("Witaj " + name);

            foreach (var item in args)
            {
                Console.WriteLine("Witaj " + item);
                
            }
        }
    }
}
