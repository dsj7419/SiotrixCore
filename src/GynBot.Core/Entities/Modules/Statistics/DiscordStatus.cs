using System;
using System.ComponentModel.DataAnnotations;

namespace Doggo
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
