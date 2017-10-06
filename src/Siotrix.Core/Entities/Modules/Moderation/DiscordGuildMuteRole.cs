using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMuteRole : Entity
    {
        public long GuildId { get; private set; }
        public string MuteRoleName{ get; private set; }

        public DiscordGuildMuteRole() { }

        public DiscordGuildMuteRole(long guildId, string muteRoleName)
        {
            GuildId = guildId;
            MuteRoleName = muteRoleName;
        }

        public void SetMuteRoleName(string muteRoleName)
        {
            MuteRoleName = muteRoleName;
        }
    }
}
