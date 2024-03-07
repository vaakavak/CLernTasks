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
            bool isOpen = true;
            Table[] tables = { new Table(1, 4), new Table(2, 6), new Table(4, 10) }; //создали столы в массиве

            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе: \n");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведите номер стола");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("\nВведите количество мест для брони");
                int desiredPlace = Convert.ToInt32(Console.ReadLine());

                bool isReservationCompleted = tables[wishTable].Reserve(desiredPlace);
                //tables - выбираем стол, wishTable - который хотим забронировать(тоесть
                //указываем его номер, desiredPlace - и пытаемся забронировать то количество мест которое хотим )

                if (isReservationCompleted )
                {
                    Console.WriteLine("Бронь прошла успешно");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла, не достаточно мест.");
                }

                Console.ReadKey();
                Console.Clear();
            }
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

        public void ShowInfo() // метод
        {                 // информация о столе
            Console.WriteLine($"Стол: {Number}. Свободно мест: {FreePlaces} из {MaxPlaces}.");
        }

        public bool Reserve(int place)
        {
            if (FreePlaces >= place) // хватает ли свободных мест
            {
                FreePlaces -= place; // если да то от свободных мест отнимаем желаемое количество мест
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
