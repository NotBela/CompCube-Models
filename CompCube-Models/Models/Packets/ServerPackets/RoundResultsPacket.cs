using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Match;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class RoundResultsPacket(Dictionary<string, Score> scores, int redPoints, int bluePoints) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.RoundResults;

    [JsonProperty("scores")]
    public readonly Dictionary<string, Score> Scores = scores;

    [JsonProperty("redPoints")]
    public readonly int RedPoints = redPoints;

    [JsonProperty("bluePoints")]
    public readonly int BluePoints = bluePoints;
}