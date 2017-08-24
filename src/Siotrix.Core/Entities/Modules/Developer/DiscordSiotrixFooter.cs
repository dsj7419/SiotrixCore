using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordSiotrixFooter : Entity
    {
        [Required]
        public string FooterText { get; private set; }
        [Required]
        public string FooterIcon { get; private set; }

        public DiscordSiotrixFooter() {}

        public DiscordSiotrixFooter(string footerText, string footerIcon)
        {
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
