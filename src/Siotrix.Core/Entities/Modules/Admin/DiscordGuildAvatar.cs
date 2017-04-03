using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAvatar : Entity
    {
        public long GuildId { get; set; }
        public string Avatar { get; set; }
    }
}
