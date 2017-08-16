using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildLogsToggle : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public string LogName { get; private set; }

        public DiscordGuildLogsToggle() { }

        public DiscordGuildLogsToggle(long guildId, string logName)
        {
            GuildId = guildId;
            LogName = logName;
        }

        public void SetLogName(string logName)
        {
            LogName = logName;
        }
    }
}
