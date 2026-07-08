using Newtonsoft.Json;

namespace CompCube_Models.Models.Map;

[method: JsonConstructor]
public class VotingMap(
    string hash,
    VotingMap.DifficultyType difficulty,
    VotingMap.Category category,
    string categoryLabel)
{
    [JsonProperty("hash")]
    public readonly string Hash = hash;

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

    public static bool operator ==(VotingMap a, VotingMap b) => a.Hash == b.Hash && a.Difficulty == b.Difficulty;
    
    public static bool operator !=(VotingMap a, VotingMap b) => !(a == b);
}