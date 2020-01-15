using System;

namespace TelegramAndConsoleBots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вид бота:1-консольный бот,2-телеграмм-бот,finish-выход из программы");

            while (true)
            {
                string userChoice = string.Empty;

                do
                {
                    userChoice = Console.ReadLine();

                    if (userChoice == "finish")
                    {
                        Environment.Exit(0);
                    }

                }
                while (userChoice != "1" && userChoice != "2");

                if (userChoice == "1")
                {
                    Console.WriteLine("Общайтесь. Если хотите закончить работу программы введите в консоли finish");

                    while (true)
                    {
                        var inputMessage = new InputMessage(Console.ReadLine());
                        HandlingMessage handlingMessage = new HandlingMessage(inputMessage.Message);

                        if (inputMessage.Message != "finish")
                        {
                            Console.WriteLine(handlingMessage.GetResultAnswer());
                        }
                        else
                        {
                            Environment.Exit(0);
                        }

                    }

                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Общайтесь. Если хотите закончить работу программы введите в консоли  finish");
                    var telegramBotWork = new TelegramBotWork();
                    telegramBotWork.StartWork();
                }

            }

        }
    }
}
