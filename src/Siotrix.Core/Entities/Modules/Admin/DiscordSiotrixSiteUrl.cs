using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordSiotrixSiteUrl : Entity
    {
        public string SiteUrl { get; set; }

        public DiscordSiotrixSiteUrl() { }

        public DiscordSiotrixSiteUrl(string siteUrl)
        {
            SiteUrl = siteUrl;
        }

        public void SetSiotrixSiteUrl(string siteUrl)
        {
            SiteUrl = siteUrl;
        }
    }
}
