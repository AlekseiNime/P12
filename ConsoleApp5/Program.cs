using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Vvod("Т/С= ");
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
                case "а": return "автомобиль - 180 км.ч";
                case "в": return "велосепед - 20 км.ч";
                case "м": return "мотоцикл - 200 км.ч";
                case "с": return "самолёт - 420 км.ч";
                case "п": return "поезд - 100 км.ч";
                default: return "Не найдено";
            }
        }
    }
}
