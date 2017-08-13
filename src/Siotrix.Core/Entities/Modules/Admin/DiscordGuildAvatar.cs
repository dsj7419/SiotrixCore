using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAvatar : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public string Avatar { get; private set; }

        public DiscordGuildAvatar() { }

        public DiscordGuildAvatar(long guildId, string avatar)
        {
            GuildId = guildId;
            Avatar = avatar;
        }

        public void SetGuildAvatar(string avatar)
        {
            Avatar = avatar;
        }
    }
}
