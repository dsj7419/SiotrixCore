using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMotd : Entity
    {
        [Required]
        public long GuildId { get; set; }
        public string Message { get; private set; }

        public DiscordGuildMotd() { }

        public DiscordGuildMotd(long guildId, string message)
        {
            GuildId = guildId;
            Message = message;
        }

        public void SetGuildMotd(string message)
        {
            Message = message;
        }
    }
}
