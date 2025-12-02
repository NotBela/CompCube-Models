using CompCube_Models.Models.ClientData;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchCreatedPacket(CompCube_Models.Models.ClientData.UserInfo[] red, CompCube_Models.Models.ClientData.UserInfo[] blue) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;

    [JsonProperty("red")]
    public readonly CompCube_Models.Models.ClientData.UserInfo[] Red = red;

    [JsonProperty("blue")] 
    public readonly CompCube_Models.Models.ClientData.UserInfo[] Blue = blue;
}