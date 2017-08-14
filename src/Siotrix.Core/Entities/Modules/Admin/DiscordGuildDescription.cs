using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildDescription : Entity
    {
        public string Description { get; private set; }
        [Required]
        public long GuildId { get; set; }

        public DiscordGuildDescription() { }

        public DiscordGuildDescription(long guildId, string desc)
        {
            Description = desc;
            GuildId = guildId;
        }

        public void SetGuildDescription(string desc)
        {
            Description = desc;
        }
    }
}
