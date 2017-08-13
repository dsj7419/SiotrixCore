using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class DiscordAuthor : Entity
    {
        [Required]
        public string AuthorIcon { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string AuthorUrl { get; set; }

        public DiscordAuthor() { }

        public DiscordAuthor(string authorIcon, string authorName, string authorUrl)
        {
            AuthorIcon = authorIcon;
            AuthorName = authorName;
            AuthorUrl = authorUrl;
        }

        public void SetAuthorIcon(string authorIcon)
        {
            AuthorIcon = authorIcon;
        }

        public void SetAuthorName(string authorName)
        {
            AuthorName = authorName;
        }

        public void SetAuthorUrl(string authorUrl)
        {
            AuthorUrl = authorUrl;
        }
    }
}
