using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordSiotrixFooter : Entity
    {
        public string FooterText { get; set; }
        public string FooterIcon { get; set; }
    }
}
