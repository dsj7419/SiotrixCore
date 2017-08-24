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
        public string Word { get; private set; }
        [Required]
        public int WarnPoints { get; private set; }

        public DiscordGuildFilterList() { }

        public DiscordGuildFilterList(long guildId, string word, int warnPoints)
        {
            GuildId = guildId;
            Word = word;
            WarnPoints = warnPoints;
        }

        public void SetWarnPoints(int warnPoints)
        {
            WarnPoints = warnPoints;
        }
    }
}
