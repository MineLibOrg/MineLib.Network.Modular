using MineLib.Network.IO;

namespace MineLib.Network.Modern.Packets.Server
{
    public struct EntityPacket : IPacket
    {
        public int EntityID;

        public byte ID { get { return 0x14; } }

        public IPacket ReadPacket(MinecraftDataReader reader)
        {
            EntityID = reader.ReadVarInt();

            return this;
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteVarInt(ID);
            stream.WriteVarInt(EntityID);
            stream.Purge();

            return this;
        }
    }
}