using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildUserCases : Entity
    {
        [Required]
        public int CaseNum { get; private set; }
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        [Required]
        public int WarningPoints { get; private set; }
        [Required]
        public string Type { get; private set; }
        public long ModId { get; private set; }
        [Required]
        public long MessageId { get; private set; }
        public string Reason { get; private set; }
        [Required]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        [Required]
        public bool IsActive { get; private set; } = true;
        [Required]
        public bool IsForgiven { get; private set; } = false;

        public DiscordGuildUserCases() { }

        public DiscordGuildUserCases(int caseNum, long guildId, long userId, int warningPoints, string type, long messageId, long modId = 0, string reason = null, bool isActive = true)
        {
            CaseNum = caseNum;
            GuildId = guildId;
            MessageId = messageId;
            UserId = userId;
            WarningPoints = warningPoints;
            Type = type;
            ModId = modId;
            Reason = reason;
            IsActive = isActive;
        }

        public void SetReason(string reason)
        {
            Reason = reason;
        }

        public void SetIsActive(bool isActive)
        {
            IsActive = isActive;
        }

        public void SetIsForgiven()
        {
            IsForgiven = true;
            IsActive = false;
        }
    }
}
