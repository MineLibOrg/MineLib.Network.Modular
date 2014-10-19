using MineLib.Network.IO;

namespace MineLib.Network.Modern.Packets.Client
{
    public struct KeepAlivePacket : IPacket
    {
        public int KeepAlive;

        public byte ID { get { return 0x00; } }

        public IPacket ReadPacket(MinecraftDataReader reader)
        {
            KeepAlive = reader.ReadVarInt();

            return this;
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteVarInt(ID);
            stream.WriteVarInt(KeepAlive);
            stream.Purge();

            return this;
        }
    }
}