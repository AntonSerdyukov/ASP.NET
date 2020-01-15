using System;

namespace TelegramAndConsoleBots
{
    class AnswerGeneration
    {
        public int GenerateNumOfAnswer()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 4);

            if (random == 1)
            {
                return 0;
            }
            else if (random == 2)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
    }
}
