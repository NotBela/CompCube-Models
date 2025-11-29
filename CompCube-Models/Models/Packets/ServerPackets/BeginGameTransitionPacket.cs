using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class BeginGameTransitionPacket(VotingMap votingMap, int transitionToGameTime, int unpauseTime) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.BeginGameTransition;

    [JsonProperty("map")] public readonly VotingMap Map = votingMap;
    [JsonProperty] public readonly int TransitionToGameTime = transitionToGameTime;
    [JsonProperty] public readonly int UnpauseTime = unpauseTime;
}