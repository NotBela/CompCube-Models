using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Match;

public class MatchResultsData(string[] winners, string[] losers, int mmrChange, bool premature, int id, DateTime time)
{
    public readonly string[] Winner = winners;
    public readonly string[] Loser = losers;
    public readonly int MmrChange = mmrChange;
    public readonly bool Premature = premature;
    public readonly int Id = id;
    public readonly DateTime Time = time;
}