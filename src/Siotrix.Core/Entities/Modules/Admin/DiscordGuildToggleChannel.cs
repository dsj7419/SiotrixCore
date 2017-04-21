using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildToggleChannel : Entity
    {
        [Required]
        public string CommandName { get; set; }
        [Required]
        public long ChannelId { get; set; }
        [Required]
        public long GuildId { get; set; }
    }
}
