namespace CompCube_Models.Models.Packets.ServerPackets;

public class AbruptDisconnectionPacket(string reason) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.AbruptDisconnection;

    public readonly string Reason = reason;
}