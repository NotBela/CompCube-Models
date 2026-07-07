using CompCube_Models.Models.Packets.ServerPackets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CompCube_Models.Models.Packets;

public abstract class ServerPacket : Packet
{
    [JsonProperty("type")]
    public abstract ServerPacketTypes PacketType { get; }
    
    public enum ServerPacketTypes
    {
        JoinResponse,
        MatchCreated,
        PlayerSelectedMap,
        RoundResults,
        StartPickPhase,
        MatchFinished
    }
    
    public static ServerPacket Deserialize(string data)
    {
        var jobj = JObject.Parse(data);
        
        if (!jobj.TryGetValue("type", out var packetTypeJToken))
            throw new Exception("Could not deserialize packet!");
        
        if (!Enum.TryParse<ServerPacketTypes>(packetTypeJToken.ToObject<string>(), out var userPacketType))
            throw new Exception("Could not deserialize packet type!");
        
        return (userPacketType switch
        {
            ServerPacketTypes.JoinResponse => JsonConvert.DeserializeObject<JoinResponsePacket>(data),
            ServerPacketTypes.MatchCreated => JsonConvert.DeserializeObject<MatchCreatedPacket>(data),
            ServerPacketTypes.RoundResults => JsonConvert.DeserializeObject<RoundResultsPacket>(data),
            ServerPacketTypes.BeginGameTransition => JsonConvert.DeserializeObject<BeginGameTransitionPacket>(data),
            ServerPacketTypes.PlayerSelectedMap => JsonConvert.DeserializeObject<PlayerSelectedMapPacket>(data),
            ServerPacketTypes.StartPickPhase => JsonConvert.DeserializeObject<StartPickPhasePacket>(data),
            _ => throw new Exception("Could not get packet type!")
        })!;
    }
}