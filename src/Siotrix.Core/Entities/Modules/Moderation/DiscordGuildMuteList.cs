﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildMuteList : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        public int MuteTime{ get; private set; }
        [Required]
        public int CaseId { get; private set; }

        public DiscordGuildMuteList() { }

        public DiscordGuildMuteList(int caseId, long guildId, long userId, int muteTime)
        {
            CaseId = caseId;
            GuildId = guildId;
            UserId = userId;
            MuteTime = muteTime;
        }

        public void SetMuteTime(int muteTime)
        {
            MuteTime = muteTime;
        }
    }
}
