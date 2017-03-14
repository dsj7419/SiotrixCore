using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class User : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }

        // Foreign Keys
        public List<CommunityUser> Communities { get; set; }
    }
}
