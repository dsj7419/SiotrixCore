using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildBlacklist : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        [Required]
        public string Username { get; private set; }

        public DiscordGuildBlacklist() { }
        public DiscordGuildBlacklist(long guildId, long userId, string username)
        {
            GuildId = guildId;
            UserId = userId;
            Username = username;
        }

        public void SetBlacklistName(string username)
        {
            Username = username;
        }
    }
}
