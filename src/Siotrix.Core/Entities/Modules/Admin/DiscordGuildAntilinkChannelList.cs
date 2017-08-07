using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAntilinkChannelList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long ChannelId { get; private set; }
        [Required]
        public bool IsActive { get; private set; }
        [Required]
        public bool IsStrict { get; private set; }
        [Required]
        public long AntilinkId { get; private set; }

        //Foreign Keys
        // public DiscordGuildAntilink DiscordGuildAntilink { get; private set; }

        public DiscordGuildAntilinkChannelList() { }
        public DiscordGuildAntilinkChannelList(long antilinkId, long guildId, long channelId, bool isActive, bool isStrict)
        {
            AntilinkId = antilinkId;
            GuildId = guildId;
            ChannelId = channelId;
            IsActive = isActive;
            IsStrict = isStrict;
        }

        public void SetIsActive(bool isActive)
        {
            IsActive = isActive;
        }

        public void SetIsStrict(bool isStrict)
        {
            IsStrict = isStrict;
        }
    }
}
