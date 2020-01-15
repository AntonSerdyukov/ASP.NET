namespace TelegramAndConsoleBots
{
    class InputMessage
    {
        public string Message { get; }
        public bool IsTelegramDialogFinish { get; }

        public InputMessage(string input)
        {
            IsTelegramDialogFinish = false;
            Message = input;
        }

    }
}
