using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildThumbNail : Entity
    {
        public string ThumbNail { get; set; }
        public long GuildId { get; set; }
    }
}
