using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildFilterList : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public string Word{ get; set; }
    }
}
