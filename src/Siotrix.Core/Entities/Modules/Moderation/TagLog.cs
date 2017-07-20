using System;

namespace Siotrix
{
    public class TagLog : Entity
    {
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
        public ulong GuildId { get; private set; }
        public ulong ChannelId { get; private set; }
        public ulong UserId { get; private set; }
        public ulong TagId { get; private set; }

        // Foreign Keys
        public Tag Tag { get; private set; }

        public TagLog() { }
        public TagLog(ulong tagId, ulong guildId, ulong channelId, ulong userId)
        {
            TagId = tagId;
            GuildId = guildId;
            ChannelId = channelId;
            UserId = userId;
        }
    }
}