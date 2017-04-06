using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildPrefix : Entity
    {
        public long GuildId { get; set; }
        public string Prefix { get; set; }
    }
}
