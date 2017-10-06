using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildBanList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        public int BanTime { get; private set; }
        [Required]
        public long CaseId { get; private set; }

        public DiscordGuildBanList() { }

        public DiscordGuildBanList(long caseId, long guildId, long userId, int banTime)
        {
            CaseId = caseId;
            GuildId = guildId;
            UserId = userId;
            BanTime = banTime;
        }

        public void SetBanTime(int banTime)
        {
            BanTime = banTime;
        }
    }
}
