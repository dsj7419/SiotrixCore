using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAnnounceChannel : Entity
    {
        [Required]
        public long ChannelId { get; set; }
        [Required]
        public long GuildId { get; set; }
    }
}
