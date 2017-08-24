using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildSiteUrl : Entity
    {
        [Required]
        public string SiteUrl { get; private set; }
        [Required]
        public long GuildId { get; set; }

        public DiscordGuildSiteUrl() { }

        public DiscordGuildSiteUrl(long guildId, string siteUrl)
        {
            GuildId = guildId;
            SiteUrl = siteUrl;
        }

        public void SetSiteUrl(string siteUrl)
        {
            SiteUrl = siteUrl;
        }
    }
}
