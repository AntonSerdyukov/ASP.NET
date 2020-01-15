using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramAndConsoleBots
{
    class TelegramBotWork
    {
        private static ITelegramBotClient botClient;

        public void StartWork()
        {
            //имя бота:ConverseTrainingBot
            botClient = new TelegramBotClient("1048793668:AAGlamoI--GQ973e6AnUatlKUyA7YqlI4ao")
            {
                Timeout = TimeSpan.FromSeconds(10)
            };            
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }

        public static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var text = e?.Message?.Text;
            HandlingMessage handlingMessage = new HandlingMessage(text);

            if (text == null)
            {
                return;
            }

            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: handlingMessage.GetResultAnswer()).ConfigureAwait(false);
        }

    }
}
