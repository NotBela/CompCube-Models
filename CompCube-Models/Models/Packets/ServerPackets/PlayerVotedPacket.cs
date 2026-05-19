using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerVotedPacket(VotingMap vote) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.OpponentVoted;
    
    [JsonProperty("vote")]
    public readonly VotingMap Vote = vote;
}