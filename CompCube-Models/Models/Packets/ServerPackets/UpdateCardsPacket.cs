using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class UpdateCardsPacket(VotingMap[] maps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.UpdateCards;
    
    public readonly VotingMap[] Maps = maps;
}