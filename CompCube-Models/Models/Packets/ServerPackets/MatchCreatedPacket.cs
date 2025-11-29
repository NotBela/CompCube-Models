using CompCube_Models.Models.ClientData;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchCreatedPacket(UserInfo[] red, UserInfo[] blue) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;

    [JsonProperty("red")]
    public readonly UserInfo[] Red = red;

    [JsonProperty("blue")] 
    public readonly UserInfo[] Blue = blue;
}