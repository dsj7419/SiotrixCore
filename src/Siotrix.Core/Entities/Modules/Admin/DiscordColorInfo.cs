using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordColorInfo : Entity
    {
        [Required]
        public int RedParam { get; set; }
        [Required]
        public int GreenParam { get; set; }
        [Required]
        public int BlueParam { get; set; }
    }
}
