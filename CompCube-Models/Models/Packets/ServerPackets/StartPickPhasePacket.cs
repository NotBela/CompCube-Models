using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class StartPickPhasePacket(VotingMap[] availableMaps, bool redPick) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.StartPickPhase;

    public readonly VotingMap[] AvailableMaps = availableMaps;

    public readonly bool RedPick = redPick;
}