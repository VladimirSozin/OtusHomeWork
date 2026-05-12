namespace GuessNumber
{
    internal class MessageProvider
    {
        public string GetHelloMessage() => "Вас приветствует программа \"Угадай число\"";
        public string GetSuccessMessage(int enteredNumber) => $"Вы угадали число!!! Было загадано число {enteredNumber}";
        public string GetWrongMessageWithBiggerSuggestion(int enteredNumber) => $"Вы не угадали число. Загаданное программой число имеет большее значение, чем {enteredNumber}. Попробуйте еще раз.";
        public string GetWrongMessageWithLessSuggestion(int enteredNumber) => $"Вы не угадали число. Загаданное программой число имеет меньшее значение, чем {enteredNumber}. Попробуйте еще раз.";
    }
}