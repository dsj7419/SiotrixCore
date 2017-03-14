using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class FilterPack : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        [Required]
        public long OwnerId { get; set; }
        [Required, Timestamp]
        public DateTime CreatedAt { get; set; }

        // Foreign Keys
        public List<Filter> Filters { get; set; }
    }
}
