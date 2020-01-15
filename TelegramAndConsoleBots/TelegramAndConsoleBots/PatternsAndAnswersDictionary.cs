using System.Collections.Generic;

namespace TelegramAndConsoleBots
{
    class PatternsAndAnswersDictionary
    {
        public Dictionary<string, string[]> Dictionary { get; }

        public PatternsAndAnswersDictionary()
        {
            Dictionary = new Dictionary<string, string[]>();
            var patterns = new Patterns();
            var answers = new Answers();
            Dictionary.Add(patterns.PatternHello, answers.AnswerHello);
            Dictionary.Add(patterns.PatternHowAreYou, answers.AnswerHowAreYou);
            Dictionary.Add(patterns.PatternWhatIsYourName, answers.AnswerWhatIsYourName);
            Dictionary.Add(patterns.PatternWhatCanYouDo, answers.AnswerWhatCanYouDo);
            Dictionary.Add(patterns.PatternWhatPointOfLife, answers.AnswerWhatPointOfLife);
            Dictionary.Add(patterns.PatternWhenWasYouBorn, answers.AnswerWhenWasYouBorn);
            Dictionary.Add(patterns.PatternWhoAreYou, answers.AnswerWhoAreYou);
            Dictionary.Add(patterns.PatternWhy, answers.AnswerWhy);
            Dictionary.Add(patterns.PatternDoYouSleep, answers.AnswerDoYouSleep);
            Dictionary.Add(patterns.PatternGoodbye, answers.AnswerGoodbye);
            Dictionary.Add(patterns.PatternTellAboutParis, answers.AnswerAboutParis);
            Dictionary.Add(patterns.PatternTellAboutMath, answers.AnswerAboutMath);
            Dictionary.Add(patterns.PatternTellAboutLondon, answers.AnswerAboutLondon);
            Dictionary.Add(patterns.PatternTellAboutBelarus, answers.AnswerAboutBelarus);
            Dictionary.Add(patterns.PatternTellAboutKangaroo, answers.AnswerAboutKangaroo);
            Dictionary.Add(patterns.PatternTellAboutCats, answers.AnswerAboutCats);
            Dictionary.Add(patterns.PatternTellAboutSun, answers.AnswerAboutSun);
            Dictionary.Add(patterns.PatternTellAboutFinland, answers.AnswerAboutFinland);
        }

    }
}
