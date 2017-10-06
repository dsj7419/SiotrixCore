using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildWarnSettings : Entity
    {
        [Required]
        public long GuildId { get; private set; }       
        public int TimesBeforeMute { get; private set; }
        public long MuteTimeLengthMinutes { get; private set; }
        public int TimesBeforeBan { get; private set; }
        public long BanTimeLengthMinutes { get; private set; }
        public int SrsInfractionsBeforePermBan { get; private set; }
        public long WarningFalloffMinutes { get; private set; }
        public bool IsActive { get; private set; }

        public DiscordGuildWarnSettings() { }

        public DiscordGuildWarnSettings(long guildId, int timesBeforeMute, long muteTimeLengthMinutes, int timesBeforeBan,
            long banTimeLengthMintues, int srsInfractionsBeforePermBan, long warningFalloffMinutes, bool isActive = false)
        {
            GuildId = guildId;
            TimesBeforeMute = timesBeforeMute;
            MuteTimeLengthMinutes = muteTimeLengthMinutes;
            TimesBeforeBan = timesBeforeBan;
            BanTimeLengthMinutes = banTimeLengthMintues;
            SrsInfractionsBeforePermBan = srsInfractionsBeforePermBan;
            WarningFalloffMinutes = warningFalloffMinutes;
            IsActive = isActive;
        }

        public void SetTimesBeforeMute(int timesBeforeMute)
        {
            TimesBeforeMute = timesBeforeMute;           
        }

        public void SetMuteTimeLengthMinutes(long muteTimeLengthMinutes)
        {
            MuteTimeLengthMinutes = muteTimeLengthMinutes;            
        }

        public void SetTimesBeforeBan(int timesBeforeBan)
        {
            TimesBeforeMute = timesBeforeBan;
        }

        public void SetBanTimeLengthMinutes(long banTimeLengthMinutes)
        {
            BanTimeLengthMinutes = banTimeLengthMinutes;
        }

        public void SetSrsInfractionsBeforePermBan(int srsInfractionsBeforePermBan)
        {
            SrsInfractionsBeforePermBan = srsInfractionsBeforePermBan;
        }

        public void SetWarningFalloffMinutes(long warningFalloffMinutes)
        {
            WarningFalloffMinutes = warningFalloffMinutes;
        }

        public void SetIsActive(bool isActive)
        {
            IsActive = isActive;
        }
    }
}