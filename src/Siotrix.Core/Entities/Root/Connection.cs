using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class Connection : Entity
    {
        [Required]
        public ConnectionType Type { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }

        // Foreign Keys
        public List<CommunityConnection> Communities { get; set; }
    }
}
