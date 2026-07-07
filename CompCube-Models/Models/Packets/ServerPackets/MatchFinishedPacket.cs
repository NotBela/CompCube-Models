using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchFinishedPacket(int eloChange, bool won) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchFinished;
    
    [JsonProperty("eloChange")]
    public readonly int EloChange = eloChange;
    
    [JsonProperty("won")]
    public readonly bool Won = won;
}