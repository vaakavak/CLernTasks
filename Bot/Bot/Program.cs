using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Polling;

namespace TelegramBotExperiments
{

    class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("7142419618:AAEvA-MOJsRzh2tYQ2QeD1cCxl4E--9G7LM");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message) // Здесь мы проверяем тип обновления. Если пользователь отправил нам сообщение, выполняем ниже описанные действия.
            {
                var message = update.Message; // Создаем новую переменную для удобства и записываем в нее всю информацию о пришедшем сообщении.
                if (message.Text.ToLower() == "/start") // Проверяем какой текст отправил пользователь. Если текст сообщения в нижнем регистре (.ToLower()) является словом "/start", то пишем ему сообщение "......". И останавливаем выполнение метода командой return.
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать в бот помошник Гипровостока. Введите команду /help для получения помощи. ");
                    return;
                }
                else if (message.Text.ToLower() == "/help")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Бот сздан для помощи в решении проблем в Гипровостоке. Вы можете оставить заявку, обязательно укажите ФИО, Отдел и Вашу поблему");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Вы отправили текстовое сообщение без команды. Я пока не умею работать с этим сообщением. Попробуйте позже...");
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // получать все типы обновлений
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}