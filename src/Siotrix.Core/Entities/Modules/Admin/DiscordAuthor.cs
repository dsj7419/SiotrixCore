using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordAuthor : Entity
    {
        public string AuthorIcon { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
    }
}
