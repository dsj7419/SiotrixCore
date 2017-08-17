using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildModLogChannel : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long ChannelId { get; private set; }
        [Required]
        public bool IsActive { get; private set; }

        public DiscordGuildModLogChannel() { }

        public DiscordGuildModLogChannel(long guildId, long channelId, bool isActive)
        {
            GuildId = guildId;
            ChannelId = channelId;
            IsActive = isActive;
        }

        public void SetModLogChannel(long channelId)
        {
            ChannelId = channelId;
        }

        public void SetModLogIsActive(bool isActive)
        {
            IsActive = isActive;
        }
    }
}
