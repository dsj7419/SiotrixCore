using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildName : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public string GuildName { get; private set; }

        public DiscordGuildName() { }

        public DiscordGuildName(long guildId, string guildName)
        {
            GuildId = guildId;
            GuildName = guildName;
        }

        public void SetGuildName(string guildName)
        {
            GuildName = guildName;
        }
    }
}
