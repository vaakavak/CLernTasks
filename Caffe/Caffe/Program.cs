using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 4), new Table(2, 6), new Table(4, 10) }; //создали столы в массиве
        }
    }

    class Table
    {
        public int Number; // количество ножек у стола
        public int MaxPlaces; // количество мест которое можно занять за столом
        public int FreePlaces; // свободные места которые остались за столом

        public Table(int number, int maxPlaces) // конструктор со значениями для "создания стола"
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

    }


}
