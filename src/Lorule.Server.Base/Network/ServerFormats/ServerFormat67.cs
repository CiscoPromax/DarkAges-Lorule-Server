﻿namespace Darkages.Network.ServerFormats
{
    public class ServerFormat67 : NetworkFormat
    {
        public byte Type = 0x03;

        public ServerFormat67()
        {
            Secured = true;
            Command = 0x67;
        }

        public override void Serialize(NetworkPacketReader reader)
        {
        }

        public override void Serialize(NetworkPacketWriter writer)
        {
            writer.Write(Type);
            writer.Write(uint.MinValue);
        }
    }
}