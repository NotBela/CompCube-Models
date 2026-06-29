using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerSelectedMapPacket(VotingMap map) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.PlayerSelectedMap;

    public readonly VotingMap Map = map;
}