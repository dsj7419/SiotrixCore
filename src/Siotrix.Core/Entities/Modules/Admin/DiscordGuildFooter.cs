using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildFooter : Entity
    {
        [Required]
        public string FooterText { get; private set; }
        [Required]
        public string FooterIcon { get; private set; }
        [Required]
        public long GuildId { get; set; }

        public DiscordGuildFooter() { }

        public DiscordGuildFooter(long guildId, string footerText, string footerIcon)
        {
            GuildId = guildId;
            FooterText = footerText;
            FooterIcon = footerIcon;
        }

        public void SetFooterText(string footerText)
        {
            FooterText = footerText;
        }

        public void SetFooterIcon(string footerIcon)
        {
            FooterIcon = footerIcon;
        }
    }
}
