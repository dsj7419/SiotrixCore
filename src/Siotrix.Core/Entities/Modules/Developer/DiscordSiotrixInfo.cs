using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordSiotrixInfo : Entity
    {
        public string BotInfo { get; private set; }

        public DiscordSiotrixInfo() { }

        public DiscordSiotrixInfo(string botInfo)
        {
            BotInfo = botInfo;
        }

        public void SetSiotrixInfo(string botInfo)
        {
            BotInfo = botInfo;
        }
    }
}
