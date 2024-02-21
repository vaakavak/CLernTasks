

//Console.WriteLine("Привет");
//Console.WriteLine("Ты здесь?");
//WriteError("Нет соединения с интернетом.", ConsoleColor.Green) ;
//Console.WriteLine("Странно...");
//WriteError("Интернет не оплачен", symbol: '@') ;

//static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!') // color и char - не обязательные параметры
//{
//    ConsoleColor defaultColor = Console.ForegroundColor;
//    Console.ForegroundColor = color;
//    Console.WriteLine(symbol + text);
//    Console.ForegroundColor = defaultColor;
//}





//int x = 7, y = 9, sum;
//sum = Sum(x, y) + x + 12;
//Console.WriteLine(sum);

//static int Sum(int x, int y)
//{
//    int sum;
//    sum = x + y;
//    return sum;
//}




//Существует два модификатора ref и out. При модицикаторе ref переменную sum обязательно нужно инициализировать, при модификаторе
//out не нужно инициализировать

//int sum, x = 1, y = 6;
//Add(out sum, x, y);
//Console.WriteLine(sum);

//static void  Add( out int sum, int x, int y)
//{
//    sum = x + y;
//}








//int[] array = new int[5];
//array = EditArray(array, 2, 5);
//Console.WriteLine(array[2]);


//static int[] EditArray(int[] array, int index, int value)
//{
//    array = new int[6];
//    array[index] = value;
//    return array;
//}






internal class Program
{
    private static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[,] array2 = new int[5, 5];
        array1 = Resize(array1, 6);
        array2 = Resize1(array2, 10, 10);
        Console.WriteLine(array1.Length);
        Console.WriteLine(array2.Length);


        static int[] Resize(int[] array, int size)
        {
            int[] tempArray = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];

            }
            array = tempArray;
            return array;
        }


        static int[,] Resize1(int[,] array, int x, int y)
        {
            int[,] tempArray = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[i, j] = array[i, j];
                }
            }
            array = tempArray;
            return array;
        }
    }
}