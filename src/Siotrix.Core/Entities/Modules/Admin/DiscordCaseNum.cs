using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordCaseNum : Entity
    {
        [Required]
        public long GuildId { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string CmdName { get; set; }
    }
}
