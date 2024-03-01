
// Stack LIFO ( lust input first out)

Stack<int> numbers = new Stack<int>();

numbers.Push(1); // добавить элемент
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);
numbers.Push(5);

Console.WriteLine(numbers.Peek());

//numbers.Pop();  // возвращает элемент извлекает его из коллекции и больше он в коллекции не находится

foreach (int number in numbers) // просматриваем элементы
{
    Console.WriteLine(number);
}

while (numbers.Count > 0) // выводим элементы с функцией Pop
{
    Console.WriteLine("Следующее число в стеке: " + numbers.Pop());
}

