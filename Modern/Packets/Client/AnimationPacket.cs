using MineLib.Network.IO;

namespace MineLib.Network.Modern.Packets.Client
{
    public struct AnimationPacket : IPacket
    {
        public byte ID { get { return 0x0A; } }

        public IPacket ReadPacket(MinecraftDataReader reader)
        {
            return this;
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteVarInt(ID);
            stream.Purge();

            return this;
        }
    }
}