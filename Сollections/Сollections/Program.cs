
// List - это коллекция, щаче используется вместо массива

List<int> numbers = new List<int>();

numbers.Add(12); //добавление по одному элементу
numbers.Add(1);
numbers.Add(2);
numbers.Add(10);
numbers.Add(5);

numbers.AddRange(new int[] { 0, 4, 9, 15, 36, 25, 81 }); //добавление нескольких элементов

numbers.RemoveAt(3); // удаление по индексу

numbers.Remove(5); // удаление элемента по совпадению

numbers.Insert(2, 123); // добавление элемента в список на позицию 2

/*numbers.Clear();*/ // очистка списка

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

Console.WriteLine("Число 9 находится на позиции " + numbers.IndexOf(9));