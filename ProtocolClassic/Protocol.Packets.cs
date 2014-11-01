﻿using System;
using MineLib.Network;
using ProtocolClassic.Enum;

namespace ProtocolClassic
{
    public partial class Protocol
    {
        private void RaisePacketHandledClassic(int id, IPacket packet, ConnectionState? state)
        {
            // -- Debugging
            Console.WriteLine("Classic ID: 0x" + String.Format("{0:X}", id));
            Console.WriteLine(" ");
            // -- Debugging

            switch ((PacketsServer)id)
            {
                case PacketsServer.ServerIdentification:
                    ConnectionState = ConnectionState.JoinedServer;
                    break;

                case PacketsServer.Ping:
                    break;

                case PacketsServer.LevelInitialize:
                    break;

                case PacketsServer.LevelDataChunk:
                    break;

                case PacketsServer.LevelFinalize:
                    break;

                case PacketsServer.SetBlock:
                    break;

                case PacketsServer.SpawnPlayer:
                    break;

                case PacketsServer.PositionAndOrientationTeleport:
                    break;

                case PacketsServer.PositionAndOrientationUpdate:
                    break;

                case PacketsServer.PositionUpdate:
                    break;

                case PacketsServer.OrientationUpdate:
                    break;

                case PacketsServer.DespawnPlayer:
                    break;

                case PacketsServer.Message:
                    break;

                case PacketsServer.DisconnectPlayer:
                    break;

                case PacketsServer.UpdateUserType:
                    break;

                case PacketsServer.ExtInfo:
                    break;

                case PacketsServer.ExtEntry:
                    break;

                case PacketsServer.SetClickDistance:
                    break;

                case PacketsServer.CustomBlockSupportLevel:
                    break;

                case PacketsServer.HoldThis:
                    break;

                case PacketsServer.SetTextHotKey:
                    break;

                case PacketsServer.ExtAddPlayerName:
                    break;

                case PacketsServer.ExtRemovePlayerName:
                    break;

                case PacketsServer.EnvSetColor:
                    break;

                case PacketsServer.MakeSelection:
                    break;

                case PacketsServer.RemoveSelection:
                    break;

                case PacketsServer.SetBlockPermission:
                    break;

                case PacketsServer.ChangeModel:
                    break;

                case PacketsServer.EnvSetMapAppearance:
                    break;

                case PacketsServer.EnvSetWeatherType:
                    break;

                case PacketsServer.HackControl:
                    break;

                case PacketsServer.ExtAddEntity2:
                    break;
            }
        }
    }
}