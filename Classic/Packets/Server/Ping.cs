﻿using MineLib.Network.IO;

namespace MineLib.Network.Classic.Packets.Server
{
    public struct PingPacket : IPacketWithSize
    {
        public byte ID { get { return 0x01; } }
        public short Size { get { return 1; } }

        public IPacketWithSize ReadPacket(MinecraftDataReader stream)
        {
            return this;
        }

        IPacket IPacket.ReadPacket(MinecraftDataReader stream)
        {
            return ReadPacket(stream);
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteByte(ID);
            stream.Purge();

            return this;
        }
    }
}
