using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMotd : Entity
    {
        public long GuildId { get; set; }
        public string Message { get; set; }
    }
}
