using System.Text.Json;

namespace GuessNumber
{
    internal class SettingsProvider
    {
        private const string SettingsFileName = "appsettings.json";

        public async Task<SettingsModel> GetSettingsAsync()
        {
            using var openStream = File.OpenRead(SettingsFileName);
            var settings = await JsonSerializer.DeserializeAsync<SettingsModel>(openStream);

            if (settings == null || settings?.TrialsCount < 0 || settings?.TrialsCount < 0)
                throw new Exception("Settings have negative values which are not supported!");

            return settings!;
        }
    }
}
