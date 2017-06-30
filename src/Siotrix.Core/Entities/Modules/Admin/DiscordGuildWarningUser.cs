using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildWarningUser : Entity
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public int PointNum { get; set; }
        public string Reason { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public long ModId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Index { get; set; }
    }
}
