using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildFilterList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public string Word{ get; private set; }

        public DiscordGuildFilterList() { }

        public DiscordGuildFilterList(long guildId, string word)
        {
            GuildId = guildId;
            Word = word;
        }

    }
}
