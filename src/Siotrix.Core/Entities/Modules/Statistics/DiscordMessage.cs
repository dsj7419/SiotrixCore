using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
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
        public bool IsBot { get; set; }
        public string GuildName { get; set; }
        public string ChannelName { get; set; }
    }
}
