﻿using MineLib.Network.IO;

namespace MineLib.Network.Classic.Packets.Server
{
    public struct OrientationUpdatePacket : IPacketWithSize
    {
        public sbyte PlayerID;
        public byte Yaw;
        public byte Pitch;

        public byte ID { get { return 0x0B; } }
        public short Size { get { return 4; } }

        public IPacketWithSize ReadPacket(MinecraftDataReader stream)
        {
            PlayerID = stream.ReadSByte();
            Yaw = stream.ReadByte();
            Pitch = stream.ReadByte();

            return this;
        }

        IPacket IPacket.ReadPacket(MinecraftDataReader stream)
        {
            return ReadPacket(stream);
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteByte(ID);
            stream.WriteSByte(PlayerID);
            stream.WriteByte(Yaw);
            stream.WriteByte(Pitch);
            stream.Purge();

            return this;
        }
    }
}
