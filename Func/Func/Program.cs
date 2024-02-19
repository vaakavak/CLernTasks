

Console.WriteLine("Привет");
Console.WriteLine("Ты здесь?");
WriteError("Нет соединения с интернетом.");
Console.WriteLine("Странно...");
WriteError("Интернет не оплачен");

static void WriteError(string text)
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = defaultColor;
}