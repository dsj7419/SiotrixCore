using System;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordReaction : Entity
    {
        [Required, Timestamp]
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [Required]
        public long AuthorId { get; set; }
        [Required]
        public long MessageId { get; set; }
        public long? EmojiId { get; set; }
        public string EmojiName { get; set; }
    }
}
