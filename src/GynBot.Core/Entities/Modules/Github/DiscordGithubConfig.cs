using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggo
{
    public class DiscordGithubConfig : Entity
    {
        public bool? IsEnabled { get; set; }
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long CommunityId { get; set; }
        
        // Foreign Keys
        public Community Community { get; set; }
        public List<DiscordGithubRepo> Repositories { get; set; }
    }
}
