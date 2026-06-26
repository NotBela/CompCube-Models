using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

public class DiscardMapPacket(VotingMap map) : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.DiscardMap;
    
    [JsonProperty("map")]
    public readonly VotingMap Map = map;
}