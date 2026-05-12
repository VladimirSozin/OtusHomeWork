using GuessNumber;

var settingsProvider = new SettingsProvider();
var settings = await settingsProvider.GetSettingsAsync();

if (settings == null || settings?.TrialsCount < 0 || settings?.TrialsCount < 0)
    throw new Exception("Settings have negative values which are not supported!");

var consoleWriter = new ConsoleWriter();
var consoleReader = new ConsoleReader();
var messageProvider = new MessageProvider();
var random = new Random();
var guessedNumber = random.Next(0, settings!.RangeSize);

consoleWriter.Write("Вас приветствует программа \"Угадай число\"");
consoleWriter.Write($"Программа загадала число в диапазоне {settings.RangeSize}, вам требуется его отгадать. Число попыток: {settings.TrialsCount}.");

while (true)
{
    consoleWriter.Write("\nПожалуйста, введите число и нажмите Enter");
    var enteredNumberString = consoleReader.ReadTextFromConsole();
    var result = int.TryParse(enteredNumberString, out var enteredNumber);

    if (enteredNumber == guessedNumber)
    {
        consoleWriter.Write($"Вы угадали число, это {guessedNumber}");
        break;
    }
    else
    {
        if (enteredNumber > guessedNumber)
        {
            messageProvider.GetWrongMessageWithLessSuggestion(enteredNumber);
        }
        else
        {
            messageProvider.GetWrongMessageWithBiggerSuggestion(enteredNumber);
        }

        continue;
    }
}