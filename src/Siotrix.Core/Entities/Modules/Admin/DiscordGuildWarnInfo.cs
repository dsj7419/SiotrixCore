using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildWarnInfo : Entity
    {
        [Required]
        public int Option { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public int WarnValue { get; set; }
    }
}
