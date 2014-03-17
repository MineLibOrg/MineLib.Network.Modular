using MineLib.Network.IO;


namespace MineLib.Network.Packets.Server
{
    public struct DisconnectPacket : IPacket
    {
        public string Reason;

        public const byte PacketID = 0x40;
        public byte Id { get { return PacketID; } }

        public void ReadPacket(ref Wrapped stream)
        {
            Reason = stream.ReadString();
        }

        public void WritePacket(ref Wrapped stream)
        {
            stream.WriteVarInt(Id);
            stream.WriteString(Reason);
            stream.Purge();
        }
    }
}