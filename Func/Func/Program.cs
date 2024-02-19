

//Console.WriteLine("Привет");
//Console.WriteLine("Ты здесь?");
//WriteError("Нет соединения с интернетом.");
//Console.WriteLine("Странно...");
//WriteError("Интернет не оплачен");

//static void WriteError(string text)
//{
//    ConsoleColor defaultColor = Console.ForegroundColor;
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(text);
//    Console.ForegroundColor = defaultColor;
//}





int x = 7, y = 9, sum;
sum = Sum(x, y) + x + 12;
Console.WriteLine(sum);

static int Sum(int x, int y)
{
    int sum;
    sum = x + y;
    return sum;
}