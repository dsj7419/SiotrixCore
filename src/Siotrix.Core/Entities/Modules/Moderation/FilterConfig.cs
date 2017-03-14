using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class FilterConfig : Entity
    {
        public bool? IsEnabled { get; set; }
        [Required]
        public long CommunityId { get; set; }

        // Foreign Keys
        public Community Community { get; set; }
        public List<Filter> Filters { get; set; }
    }
}
