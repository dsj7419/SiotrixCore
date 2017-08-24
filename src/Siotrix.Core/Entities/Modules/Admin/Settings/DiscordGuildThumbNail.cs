using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildThumbNail : Entity
    {
        [Required]
        public string ThumbNail { get; set; }
        [Required]
        public long GuildId { get; set; }

        public DiscordGuildThumbNail() { }

        public DiscordGuildThumbNail(long guildId, string thumbNail)
        {
            GuildId = guildId;
            ThumbNail = thumbNail;
        }

        public void SetGuildThumbNail(string thumbNail)
        {
            ThumbNail = thumbNail;
        }
    }
}
