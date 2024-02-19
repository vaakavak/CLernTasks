// Вывод массива по индексу

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}



// Вывод элементов массива 

foreach (int number in numbers)
{
    Console.Write(number + " ");
}  