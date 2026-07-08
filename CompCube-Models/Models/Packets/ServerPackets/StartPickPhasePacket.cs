using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class StartPickPhasePacket(VotingMap[] availableMaps, bool isOwnPick, float newMultiplier) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.StartPickPhase;

    [JsonProperty("availablePicks")]
    public readonly VotingMap[] AvailableMaps = availableMaps;

    [JsonProperty("isOwnPick")]
    public readonly bool IsOwnPick = isOwnPick;

    [JsonProperty("newMultiplier")] 
    public readonly float NewMultiplier = newMultiplier;
}