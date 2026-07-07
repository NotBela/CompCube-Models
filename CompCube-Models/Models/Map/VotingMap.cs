using Newtonsoft.Json;

namespace CompCube_Models.Models.Map;

[method: JsonConstructor]
public class VotingMap(
    string key,
    VotingMap.DifficultyType difficulty,
    VotingMap.Category category,
    string categoryLabel)
{
    [JsonProperty("hash")]
    public readonly string Key = key;

    [JsonProperty("difficulty")]
    public readonly DifficultyType Difficulty = difficulty;

    [JsonProperty("categoryLabel")] 
    public readonly string CategoryLabel = categoryLabel;

    [JsonProperty("category")] 
    public readonly Category MapCategory = category;

    public enum Category
    {
        Unknown
    }
    
    public enum DifficultyType
    {
        Easy,
        Normal,
        Hard,
        Expert,
        ExpertPlus
    }
}