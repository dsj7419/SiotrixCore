using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordBanGuildList : Entity
    {
        public long GuildId { get; set; }
        public string Reason { get; set; }
        public string GuildName { get; set; }
    }
}
