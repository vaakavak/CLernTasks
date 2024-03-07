using System;
using Telegram.Bot;


namespace Giprovostokneft
{
    class Program
    {
        private static ITelegramBotClient botClient;

        static async Task Main(string[] args)
        {
            botClient = new TelegramBotClient("7142419618:AAEvA-MOJsRzh2tYQ2QeD1cCxl4E--9G7LM") { Timeout = TimeSpan.FromSeconds(10)};

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Bot id: {me.Id}. Bot name {me.FirstName}");

            botClient.OnMessage += Bot_OnMessage;

            Console.ReadKey();
        }


    }
}
