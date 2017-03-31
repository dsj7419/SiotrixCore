using System;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordColor : Entity
    {
        public long? GuildId { get; set; }
        public int ColorId { get; set; }
    }
}