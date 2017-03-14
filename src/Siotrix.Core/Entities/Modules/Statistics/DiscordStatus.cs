using System;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordStatus : Entity
    {
        [Required, Timestamp]
        public DateTime Timestamp { get; set; }
        public long? GuildId { get; set; }
        [Required]
        public DiscordStatusType Status { get; set; }
    }
}
