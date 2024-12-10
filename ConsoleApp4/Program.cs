using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Vvod("letter= ");
            string x = GetName(n);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static string Vvod(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static string GetName(string letter)
        {
            switch (letter.ToLower())
            {
                case "ф": return "физика";
                case "м": return "математика";
                case "и": return "история";
                case "г": return "география";
                case "б": return "биология";
                default: return "Не найдено";
            }
        }
    }
}
