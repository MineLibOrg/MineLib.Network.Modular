﻿using MineLib.Network.Classic.Enums;
using MineLib.Network.IO;

namespace MineLib.Network.Classic.Packets.Extension.Server
{
    public struct SetTextHotKeyPacket : IPacketWithSize
    {
        public string Label;
        public string Action;
        public int KeyCode;
        public KeyMods KeyMods;

        public byte ID { get { return 0x15; } }
        public short Size { get { return 134; } }

        public IPacketWithSize ReadPacket(MinecraftDataReader stream)
        {
            Label = stream.ReadString();
            Action = stream.ReadString();
            KeyCode = stream.ReadInt();
            KeyMods = (KeyMods) stream.ReadByte();

            return this;
        }

        IPacket IPacket.ReadPacket(MinecraftDataReader stream)
        {
            return ReadPacket(stream);
        }

        public IPacket WritePacket(MinecraftStream stream)
        {
            stream.WriteByte(ID);
            stream.WriteString(Label);
            stream.WriteString(Action);
            stream.WriteInt(KeyCode);
            stream.WriteByte((byte) KeyMods);
            stream.Purge();

            return this;
        }
    }
}
