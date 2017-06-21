using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAnnounceMessage : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public int MessageId { get; set; }
    }
}
