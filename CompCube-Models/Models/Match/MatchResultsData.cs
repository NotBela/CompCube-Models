using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Match;

public class MatchResultsData(UserInfo[] winners, UserInfo[] losers, int mmrChange, bool premature, int id, DateTime time)
{
    public readonly UserInfo[] Winner = winners;
    public readonly UserInfo[] Loser = losers;
    public readonly int MmrChange = mmrChange;
    public readonly bool Premature = premature;
    public readonly int Id = id;
    public readonly DateTime Time = time;
}