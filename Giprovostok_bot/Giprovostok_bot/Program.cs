using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Extensions.Polling;

class Program
{
    static readonly TelegramBotClient botClient = new TelegramBotClient("YOUR_BOT_TOKEN");
    static CancellationTokenSource cts;

    static void Main(string[] args)
    {
        cts = new CancellationTokenSource();
        botClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, cts.Token);
        Console.ReadLine();
        botClient.StopReceiving(cts.Token);
    }

    async static Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Type == UpdateType.Message)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                switch (message.Text.ToLower())
                {
                    case "/start":
                        await botClient.SendTextMessageAsync(message.Chat.Id, "Hello! Welcome to my bot.");
                        break;

                    default:
                        await botClient.SendTextMessageAsync(message.Chat.Id, "Sorry, I didn't understand that.");
                        break;
                }
            }
        }
    }

    async static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        Console.Error.WriteLine(exception.Message);
    }
}
