using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAutoDelete : Entity
    {
        public long GuildId { get; set; }
        public int Option { get; set; }
    }
}
