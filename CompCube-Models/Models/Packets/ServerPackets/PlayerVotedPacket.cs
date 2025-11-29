using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerVotedPacket(int voteIndex, string userId) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.OpponentVoted;
    
    [JsonProperty("vote")]
    public readonly int VoteIndex = voteIndex;

    [JsonProperty("userId")] 
    public readonly string UserId = userId;
}