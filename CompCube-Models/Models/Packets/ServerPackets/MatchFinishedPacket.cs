using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchFinishedPacket(int eloChange, bool redWon) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchFinished;
    
    [JsonProperty("eloChange")]
    public readonly int EloChange = eloChange;
    
    [JsonProperty("redWon")]
    public readonly bool RedWon = redWon;
}