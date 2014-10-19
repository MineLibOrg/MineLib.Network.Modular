using MineLib.Network.IO;

namespace MineLib.Network.Modern.Packets.Client
{
    public struct PlayerPacket : IPacket
    {
        public bool OnGround;

        public byte ID { get { return 0x03; } }

        public IPacket ReadPacket(MinecraftDataReader reader)
        {
            OnGround = reader.ReadBoolean();

            return this;
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteVarInt(ID);
            stream.WriteBoolean(OnGround);
            stream.Purge();

            return this;
        }
    }
}