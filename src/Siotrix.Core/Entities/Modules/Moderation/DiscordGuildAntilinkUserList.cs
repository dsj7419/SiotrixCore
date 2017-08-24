using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAntilinkUserList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long ChannelId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        [Required]
        public bool IsOneTime { get; private set; }
        [Required]
        public long AntilinkId { get; private set; }

        //Foreign Keys
   //     public DiscordGuildAntilink DiscordGuildAntilink { get; private set; }

        public DiscordGuildAntilinkUserList() { }
        public DiscordGuildAntilinkUserList(long antilinkId, long guildId, long channelId, long userId, bool isOneTime)
        {
            AntilinkId = antilinkId;
            GuildId = guildId;
            ChannelId = channelId;
            UserId = userId;
            IsOneTime = isOneTime;
        }

        public void SetIsOneTime(bool isOneTime)
        {
            IsOneTime = isOneTime;
        }
    }
}
