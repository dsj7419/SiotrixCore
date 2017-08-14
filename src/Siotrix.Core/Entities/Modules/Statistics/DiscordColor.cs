using System;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordColor : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public string ColorHex { get; private set; }

        public DiscordColor() { }

        public DiscordColor(long guildId, string colorHex)
        {
            GuildId = guildId;
            ColorHex = colorHex;
        }

        public void SetGuildColorHex(string colorHex)
        {
            ColorHex = colorHex;
        }
    }
}