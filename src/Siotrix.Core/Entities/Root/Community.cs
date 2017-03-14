using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class Community : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public bool IsPrivate { get; set; }

        // Foreign Keys
        public List<CommunityUser> Users { get; set; }
        public List<CommunityConnection> Connections { get; set; }
    }
}
