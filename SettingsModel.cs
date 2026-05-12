using System.Text.Json.Serialization;

namespace GuessNumber
{
    internal class SettingsModel
    {
        [JsonPropertyName("trialsCount")]
        public int TrialsCount { get; set; }

        [JsonPropertyName("rangeSize")]
        public int RangeSize { get; set; }
    }
}
