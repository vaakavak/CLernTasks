using Telegram.Bot;
using Telegram.Bot.Types;


internal class Program
{
    private static TelegramBotClient _botClient;
    private static void Main(string[] args)
    {
        _botClient = new TelegramBotClient("7142419618:AAEvA - MOJsRzh2tYQ2QeD1cCxl4E--9G7LM");
        _botClient.OnMessage += Bot_OnMessage;
        _botClient.StartReceiving();

        Console.WriteLine("Bot started. Press any key to exit...");

        // Отправляем приветственное сообщение при запуске бота
        _botClient.SendTextMessageAsync("YOUR_CHAT_ID", "Привет!");

        Console.ReadKey();

        _botClient.StopReceiving();
        
    }

}