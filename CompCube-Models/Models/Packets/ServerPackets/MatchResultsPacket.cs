using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchResultsPacket(int mmrChange) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchResults;
    
    [JsonProperty("mmrChange")]
    public readonly int MmrChange = mmrChange;
}