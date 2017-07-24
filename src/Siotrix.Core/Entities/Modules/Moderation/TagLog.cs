using System;

namespace Siotrix
{
    public class TagLog : Entity
    {
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
        public long GuildId { get; private set; }
        public long ChannelId { get; private set; }
        public long UserId { get; private set; }
        public long TagId { get; private set; }

        // Foreign Keys
        public Tag Tag { get; private set; }

        public TagLog() { }
        public TagLog(long tagId, long guildId, long channelId, long userId)
        {
            TagId = tagId;
            GuildId = guildId;
            ChannelId = channelId;
            UserId = userId;
        }
    }
}