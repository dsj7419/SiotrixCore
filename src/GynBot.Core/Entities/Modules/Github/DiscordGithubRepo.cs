using System.ComponentModel.DataAnnotations;

namespace Doggo
{
    public class DiscordGithubRepo : Entity
    {
        [Required]
        public string Name { get; set; }
        public long? ChannelId { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long ConfigId { get; set; }

        // Foreign Keys
        public DiscordGithubConfig Config { get; set; }
    }
}
