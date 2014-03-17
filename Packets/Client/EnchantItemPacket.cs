using MineLib.Network.IO;


namespace MineLib.Network.Packets.Client
{
    public struct EnchantItemPacket : IPacket
    {
        public byte WindowId;
        public byte Enchantment;

        public const byte PacketID = 0x11;
        public byte Id { get { return PacketID; } }

        public void ReadPacket(ref Wrapped stream)
        {
            WindowId = stream.ReadByte();
            Enchantment = stream.ReadByte();
        }

        public void WritePacket(ref Wrapped stream)
        {
            stream.WriteVarInt(Id);
            stream.WriteVarInt(WindowId);
            stream.WriteVarInt(Enchantment);
            stream.Purge();
        }
    }
}