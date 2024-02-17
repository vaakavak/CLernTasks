// Array

//int[] array = {2, 3, 4, 5, 6};
//int summ = 0;

//for  (int i = 0; i < array.Length; i++)
//{
//    summ += array[i];
//}
//Console.WriteLine(summ);





// Нахождение максимального 

//int[] array = { 2, -4, 17, 14, 9, -11 };
//int maxValue = int.MinValue;

//for (int i = 0; i < array.Length; i++)
//{
//    if (maxValue < array[i])
//    {
//        maxValue = array[i];    

//    }

//}

//Console.WriteLine($"Максимальное значение {maxValue}");






// Бронирование мест в самолете

//int[] sektors = { 6, 28, 15, 15, 17 };
//bool isOpen = true;

//while (isOpen)
//{
//    Console.SetCursorPosition(0, 18);
//    for (int i = 0; i < sektors.Length; i++)
//    {
//        Console.WriteLine($"В секторе {i + 1} свободно {sektors[i]} мест.");

//    }

//    Console.SetCursorPosition(0, 0);
//    Console.WriteLine("Регистация рейса.");
//    Console.WriteLine("\n\n1 - Забронировать места\n\n2 - выход из программы\n\n");
//    Console.Write("Введите номер команды: ");

//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            int userSector, userPlaceAmount;
//            Console.Write("В каком секторе вы хотите лететь? ");
//            userSector = Convert.ToInt32(Console.ReadLine()) - 1;
//            if (sektors.Length <= userSector || userSector < 0)
//            {
//                Console.WriteLine("Такого сектора не существует");
//                break;
//            }
//            Console.Write("Сколько мест вы хотите забронировать? ");
//            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
//            if (sektors[userSector] < userPlaceAmount || userPlaceAmount < 0)
//            {
//                Console.WriteLine($"В секторе {userSector} недостаточно мест. Мест осталось {sektors[userSector]}");
//                break;
//            }
//            sektors[userSector] -= userPlaceAmount;
//            Console.WriteLine("Бронирование успешно");
//            break;
//            case 2:
//            isOpen = false;
//            break;

//    }

//    Console.ReadKey();
//    Console.Clear();
//}






// Многомерный массив

//int[,] arrays = {
//    { 2, 3, 4 },
//    { 5, 4, 5 },
//    { 2, 6, 7 } };

//for (int i = 0; i < arrays.GetLength(0); i++)
//{
//    for (int j = 0; j < arrays.GetLength(1); j++)
//    {
//        Console.Write(arrays[i, j] + " ");
//    }
//    Console.WriteLine();
//}





// Книги в библиотеке

bool isOpen = true;

string[,] books =
{
    {"Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин" },
    {"Роберт Мартин", "Джеси Шел", "Сергей Тепляков" },
    {"Стивен кинг", "Говард Лавкрафт", "Брем Стокер" }
};

while (isOpen)
{
    Console.SetCursorPosition(0, 20);
    Console.WriteLine("\nВесь список авторов\n");
    for (int i = 0; i < books.GetLength(0); i++)
    {
        for (int j = 0; j < books.GetLength(1); j++)
        {
            Console.Write(books[i, j] + " | ");
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Библиотека");
    Console.WriteLine("1 - узнать имя автора по индексу книги.2 - найти книгу по автору. 3 - выход.");
    Console.ReadKey();
}