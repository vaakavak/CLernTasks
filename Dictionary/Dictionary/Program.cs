using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> counrtiesCapitals = new Dictionary<string, string>();
            counrtiesCapitals.Add("Австралия", "Конберра");
            counrtiesCapitals.Add("Турция", "Анкара");
            counrtiesCapitals.Add("Швейцария", "Берн");

            //counrtiesCapitals.Remove("Турция"); // удаление элементов

            //if (counrtiesCapitals.ContainsKey("Австралия"))
            //    Console.WriteLine(counrtiesCapitals["Австралия"]);  // вывод значения по ключу

            foreach (var item in counrtiesCapitals)
            {
                Console.WriteLine($"Страна {item.Key} - столица {item.Value}");
            }

            foreach (var key in counrtiesCapitals.Keys)
            {
                Console.WriteLine($"Страна - {key}") ;
            }

            foreach (var value in counrtiesCapitals.Values)
            {
                Console.WriteLine($"Столица - {value}");
            }
            Console.ReadKey();
        }
    }
}
