﻿using MineLib.Network.IO;
using Org.BouncyCastle.Math;

namespace MineLib.Network.Modern.Packets.Client
{
    public struct SpectatePacket : IPacket
    {
        public BigInteger UUID;

        public byte ID { get { return 0x18; } }

        public IPacket ReadPacket(MinecraftDataReader reader)
        {
            UUID = reader.ReadBigInteger();

            return this;
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteVarInt(ID);
            stream.WriteBigInteger(UUID);
            stream.Purge();

            return this;
        }
    }
}
