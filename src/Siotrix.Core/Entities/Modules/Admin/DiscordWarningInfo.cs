using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordWarningInfo : Entity
    {
        public int Level { get; set; }
        public string Info { get; set; }
    }
}
