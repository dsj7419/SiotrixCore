using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordGuildAntilink : Entity
    {
        [Required]
        public long GuildId { get; private set; }
        [Required]
        public bool IsActive { get; private set; }
        [Required]
        public bool IsDmMessage { get; private set; }
        public string DmMessage { get; private set; }

        public DiscordGuildAntilink() { }
        public DiscordGuildAntilink(long guildId, bool isActive, bool isDmMessage, string dmMessage)
        {
            GuildId = guildId;
            IsActive = isActive;
            IsDmMessage = isDmMessage;
            DmMessage = dmMessage;
        }

        public void SetIsActive(bool isActive)
        {
            IsActive = isActive;
        }

        public void SetIsDmMessage(bool isOn)
        {
            IsDmMessage = isOn;
        }

        public void SetDmMessage(string message)
        {
            DmMessage = message;
        }
    }
}
