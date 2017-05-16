using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMuteRole : Entity
    {
        public long GuildId { get; set; }
        public string MuteRoleName{ get; set; }
    }
}
