using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildModLogChannel : Entity
    {
        [Required]
        public long ChannelId { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public long ModeratorId { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
