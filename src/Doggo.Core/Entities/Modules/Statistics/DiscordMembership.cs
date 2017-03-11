using System;
using System.ComponentModel.DataAnnotations;

namespace Doggo
{
    public class DiscordMembership : Entity
    {
        [Required, Timestamp]
        public DateTime Timestamp { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public bool IsJoining { get; set; }
    }
}
