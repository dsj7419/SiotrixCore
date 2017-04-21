using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildToggle : Entity
    {
        [Required]
        public string CommandName { get; set; }
        [Required]
        public long GuildId { get; set; }
    }
}
