using System.Linq;
using System.Text.RegularExpressions;

namespace TelegramAndConsoleBots
{
    class HandlingMessage
    {
        public string InputMessage { get; }

        public HandlingMessage(string inputMessage)
        {
            InputMessage = inputMessage;
        }

        public string GetResultAnswer()
        {
            var patternsAndAnswersDictionary = new PatternsAndAnswersDictionary();
            bool isPatternFound = false;
            string[] patterns = patternsAndAnswersDictionary.Dictionary.Keys.ToArray();
            string[][] answers = patternsAndAnswersDictionary.Dictionary.Values.ToArray();
            var answerGeneration = new AnswerGeneration();
            string resultAnswer = string.Empty;

            if (InputMessage == string.Empty)
            {
                return string.Empty;
            }

            for (int i = 0; i < patternsAndAnswersDictionary.Dictionary.Count; i++)
            {

                if (Regex.IsMatch(InputMessage.ToLower(), patterns[i]))
                {
                    resultAnswer = answers[i][answerGeneration.GenerateNumOfAnswer()];
                    isPatternFound = true;
                    break;
                }

            }

            if (isPatternFound == false)
            {
                var answer = new Answers();
                resultAnswer = answer.AnswerNothing[answerGeneration.GenerateNumOfAnswer()];
            }

            return resultAnswer;
        }

    }
}
