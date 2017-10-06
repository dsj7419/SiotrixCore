using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuilUserCaseTracking : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public long UserId { get; private set; }
        public int ActiveWarningUserPoints { get; private set; }
        public int SeriousUserInfractions { get; private set; }
        public int ForgivenWarningUserPoints { get; private set; }
        public int ForgivenSeriousUserInfractions { get; private set; }
        public int TotalWarningUserPoints { get; private set; }
        public int NumberUserMutes { get; private set; }
        public int NumberUserKicks { get; private set; }
        public int NumberUserBans { get; private set; }

        public DiscordGuilUserCaseTracking() { }

        public DiscordGuilUserCaseTracking(long guildId, long userId, int activeWarningUserPoints = 0, int seriousUserInfractions = 0, int forgivenWarningUserPoints = 0,
            int forgivenSeriousUserInfractions = 0, int totalWarningUserPoints = 0, int numberUserMutes = 0, int numberUserKicks = 0, int numberUserBans = 0)
        {
            GuildId = guildId;
            UserId = userId;
            ActiveWarningUserPoints = activeWarningUserPoints;
            SeriousUserInfractions = seriousUserInfractions;
            ForgivenWarningUserPoints = forgivenWarningUserPoints;
            ForgivenSeriousUserInfractions = forgivenSeriousUserInfractions;
            TotalWarningUserPoints = totalWarningUserPoints;
            NumberUserMutes = numberUserMutes;
            NumberUserKicks = numberUserKicks;
            NumberUserBans = numberUserBans;
        }

        public void SetActiveWarningUserPoints(int activeWarningUserPoints)
        {
            ActiveWarningUserPoints = activeWarningUserPoints;
        }

        public void SetSeriousUserInfraction(int infraction)
        {
            SeriousUserInfractions = infraction;
        }

        public void SetForgivenWarningUserPoints(int forgivenWarningUserPoints)
        {
            ForgivenWarningUserPoints = forgivenWarningUserPoints;
        }

        public void SetForgivenSeriousUserInfractions(int forgivenSeriousUserInfractions)
        {
            ForgivenSeriousUserInfractions = forgivenSeriousUserInfractions;
        }

        public void SetTotalWarningUserPoints(int totalWarningUserPoints)
        {
            TotalWarningUserPoints = totalWarningUserPoints;
        }

        public void SetNumberUserMutes(int numberUserMutes)
        {
            NumberUserMutes = numberUserMutes;
        }

        public void SetNumberUserKicks(int numberUserKicks)
        {
            NumberUserKicks = numberUserKicks;
        }

        public void SetNumberUserBans(int numberUserBans)
        {
            NumberUserBans = numberUserBans;
        }
    }
}
