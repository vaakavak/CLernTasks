

Console.WriteLine("Привет");
Console.WriteLine("Ты здесь?");
WriteError();
Console.WriteLine("Странно...");
WriteError();

static void WriteError()
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Нет соединения с интернетом.");
    Console.ForegroundColor = defaultColor;
}