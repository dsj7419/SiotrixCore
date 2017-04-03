using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildDescription : Entity
    {
        public string Description { get; set; }
        public long GuildId { get; set; }
    }
}
