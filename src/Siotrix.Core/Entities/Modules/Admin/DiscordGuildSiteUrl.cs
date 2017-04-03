using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildSiteUrl : Entity
    {
        public string SiteUrl { get; set; }
        public long GuildId { get; set; }
    }
}
