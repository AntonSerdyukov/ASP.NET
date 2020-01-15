namespace TelegramAndConsoleBots
{
    class Patterns
    {

        public Patterns()
        {
            PatternHello = @"(\w?)привет(\w?)|(\w?)здрасте(\w?)|(\w?)салют(\w?)|(\w?)здравствуй(\w?)|(\w?)добр(\w+)день(\w?)|(\w?)добр(\w+)утр(\w?)|(\w?)добр(\w+)вечер(\w?)|(\w?)добр(\w+)ноч(\w?)|(\w?)доброго(\s+)времени(\s+)суток(\w?)";
            PatternHowAreYou = @"(\w?)как(\s+)дел(\w?)|(\w?)дела(\s+)как(\w?)";
            PatternWhoAreYou = @"(\w?)кто(\s+)(\w?)ты(\w?)| (\w?)ты(\s+)(\w?)кто(\w?)";
            PatternWhatCanYouDo = @"(\w?)что(\s+)(.*)можешь(\w?)|(\w?)что(\s+)(.*)умеешь(\w?)|(\w?)можешь(\s+)(.*)что(\w?)|(\w?)умеешь(\s+)(.*)что(\w?)";
            PatternWhatIsYourName = @"(\w?)твое(\s+)имя(.*)(\w?)|(\w?)тебя(\s+)(.*)зовут(\w?)|(\w?)cвое(\s+)имя(.*)(\w?)|(\w?)тебя(\s+)(.*)звать(\w?)|(\w?)имя(\s+)твое(.*)(\w?)|(\w?)зовут(\s+)(.*)тебя(\w?)|(\w?)имя(\s+)свое(.*)(\w?)|(\w?)звать(\s+)(.*)тебя(\w?)";
            PatternWhenWasYouBorn = @"(\w?)когда(.*)ты(.*)родился(\w?)|(\w?)ты(.*)когда(.*)родился(\w?)|(\w?)когда(.*)родился(.*)ты(\w?)|(\w?)ты(.*)когда(.*)родился(\w?)";
            PatternDoYouSleep = @"(\w?)ты(.*)спишь(\w?)|(\w?)спишь(.*)ты(\w?)";
            PatternGoodbye = @"(\w?)пока(\w?)|(\w?)до(.*)свидания(\w?)|(\w?)до(.*)встречи(\w?)";
            PatternWhatPointOfLife = @"(\w?)смысл(.*)жизни(\w?)| (\w?)жизни(.*)смысл(\w?)";
            PatternWhy = @"(\w?)почему(\w?)";
            PatternTellAboutParis = @"(\w?)расска(\w*)(.*)париж(\w?)|(\w?)париж(\w*)(.*)расска(\w?)";
            PatternTellAboutMath = @"(\w?)расска(\w*)(.*)математи(\w?)|(\w?)математи(\w*)(.*)расска(\w?)";
            PatternTellAboutLondon = @"(\w?)расска(\w*)(.*)лондон(\w?)|(\w?)лондон(\w*)(.*)расска(\w?)";
            PatternTellAboutBelarus = @"(\w?)расска(\w*)(.*)беларус(\w?)|(\w?)беларус(\w*)(.*)расска(\w?)";
            PatternTellAboutKangaroo = @"(\w?)расска(\w*)(.*)кенгуру(\w?)|(\w?)кенгуру(\w*)(.*)расска(\w?)";
            PatternTellAboutCats = @"(\w?)расска(\w*)(.*)кoшк(\w?)|(\w?)кошк(\w*)(.*)расска(\w?)|(\w?)кот(\w*)(.*)расска(\w?)|(\w?)расска(\w*)(.*)кот(\w?)";
            PatternTellAboutSun = @"(\w?)расска(\w*)(.*)солнце(\w?)|(\w?)солнце(\w*)(.*)расска(\w?)";
            PatternTellAboutFinland = @"(\w?)расска(\w*)(.*)финлянди(\w?)|(\w?)финлянди(\w*)(.*)расска(\w?)";
        }

        public string PatternHello { get; }
        public string PatternHowAreYou { get; }
        public string PatternWhoAreYou { get; }
        public string PatternWhatCanYouDo { get; }
        public string PatternWhatIsYourName { get; }
        public string PatternWhenWasYouBorn { get; }
        public string PatternDoYouSleep { get; }
        public string PatternGoodbye { get; }
        public string PatternWhatPointOfLife { get; }
        public string PatternWhy { get; }
        public string PatternTellAboutParis { get; }
        public string PatternTellAboutMath { get; }
        public string PatternTellAboutLondon { get; }
        public string PatternTellAboutBelarus { get; }
        public string PatternTellAboutKangaroo { get; }
        public string PatternTellAboutCats { get; }
        public string PatternTellAboutSun { get; }
        public string PatternTellAboutFinland { get; }
    }
}
