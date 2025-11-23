using CompCube_Models.Models.ClientData;
using CompCube_Server.Gameplay.Match;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Match;

[method: JsonConstructor]
public class TeamData(Team.TeamName teamName, UserInfo[] players)
{
    [JsonProperty("name")] public readonly Team.TeamName TeamName = teamName;

    [JsonProperty("players")] public readonly UserInfo[] Players = players;
}