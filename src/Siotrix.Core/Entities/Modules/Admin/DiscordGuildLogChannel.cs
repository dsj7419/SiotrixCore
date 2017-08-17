using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildLogChannel : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long ChannelId { get; private set; }
        [Required]
        public bool IsActive { get; private set; }

        public DiscordGuildLogChannel() { }

        public DiscordGuildLogChannel(long guildId, long channelId, bool isActive)
        {
            GuildId = guildId;
            ChannelId = channelId;
            IsActive = isActive;
        }

        public void SetLogChannel(long channelId)
        {
            ChannelId = channelId;
        }

        public void SetLogIsActive(bool isActive)
        {
            IsActive = isActive;
        }
    }
}
