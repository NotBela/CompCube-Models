using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class StartPickPhasePacket(VotingMap[] availableMaps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.StartPickPhase;

    public readonly VotingMap[] AvailableMaps = availableMaps;
}