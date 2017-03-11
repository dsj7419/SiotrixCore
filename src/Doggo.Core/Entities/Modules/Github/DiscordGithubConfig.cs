using System.Collections.Generic;

namespace Doggo
{
    public class DiscordGithubConfig : Entity
    {
        public bool IsEnabled { get; set; }
        public long GuildId { get; set; }
        public long CommunityId { get; set; }
        
        // Foreign Keys
        public Community Community { get; set; }
        public List<DiscordGithubRepo> Repositories { get; set; }
    }
}
