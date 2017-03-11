using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggo
{
    public class DiscordMessage : Entity
    {
        [Required, Timestamp]
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long? GuildId { get; set; }
        public long? ChannelId { get; set; }
        [Required]
        public long MessageId { get; set; }
        [Required]
        public long AuthorId { get; set; }
        public string Content { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
