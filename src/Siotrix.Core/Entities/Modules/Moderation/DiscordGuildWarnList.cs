using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildWarnList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        public int WarnTime { get; private set; }
        [Required]
        public long CaseId { get; private set; }

        public DiscordGuildWarnList() { }

        public DiscordGuildWarnList(long caseId, long guildId, long userId, int warnTime)
        {
            CaseId = caseId;
            GuildId = guildId;
            UserId = userId;
            WarnTime = warnTime;
        }

        public void SetWarnTime(int warnTime)
        {
            WarnTime = warnTime;
        }
    }
}
