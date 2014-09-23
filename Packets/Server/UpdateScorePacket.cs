using MineLib.Network.IO;

namespace MineLib.Network.Packets.Server
{
    public struct UpdateScorePacket : IPacket
    {
        public string ScoreName;
        public bool RemoveItem; // Will be converted to byte 0-1
        public string ObjectiveName;
        public int? Value;

        public const byte PacketID = 0x3C;
        public byte Id { get { return PacketID; } }

        public void ReadPacket(PacketByteReader reader)
        {
            ScoreName = reader.ReadString();
            RemoveItem = reader.ReadBoolean();
            if (!RemoveItem)
            {
                ObjectiveName = reader.ReadString();
                Value = reader.ReadInt();
            }
        }

        public void WritePacket(ref PacketStream stream)
        {
            stream.WriteVarInt(Id);
            stream.WriteString(ScoreName);
            stream.WriteBoolean(RemoveItem);
            if (!RemoveItem)
            {
                stream.WriteString(ObjectiveName);
                stream.WriteInt(Value.Value);
            }
            stream.Purge();
        }
    }
}