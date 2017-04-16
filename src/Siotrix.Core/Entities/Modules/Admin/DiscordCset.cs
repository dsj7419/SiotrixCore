using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordCset : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long ChannelId { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
