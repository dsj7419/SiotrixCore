using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMuteList : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long UserId { get; set; }
        public int MuteTime{ get; set; }
    }
}
