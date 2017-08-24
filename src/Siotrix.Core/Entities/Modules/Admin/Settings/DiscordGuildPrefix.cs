using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildPrefix : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public string Prefix { get; private set; }

        public DiscordGuildPrefix() { }

        public DiscordGuildPrefix(long guildId, string prefix)
        {
            GuildId = guildId;
            Prefix = prefix;
        }

        public void SetGuildPrefix(string prefix)
        {
            Prefix = prefix;
        }
    }
}
