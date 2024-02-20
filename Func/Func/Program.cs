

Console.WriteLine("Привет");
Console.WriteLine("Ты здесь?");
WriteError("Нет соединения с интернетом.", ConsoleColor.Green) ;
Console.WriteLine("Странно...");
WriteError("Интернет не оплачен", symbol: '@') ;

static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(symbol + text);
    Console.ForegroundColor = defaultColor;
}





int x = 7, y = 9, sum;
sum = Sum(x, y) + x + 12;
Console.WriteLine(sum);

static int Sum(int x, int y)
{
    int sum;
    sum = x + y;
    return sum;
}