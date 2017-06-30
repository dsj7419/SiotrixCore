using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAnnounceToggleOrDM : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public int CommandId { get; set; }
        [Required]
        public int Option { get; set; }
    }
}
