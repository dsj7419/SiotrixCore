using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class Filter : Entity
    {
        [Required]
        public string Word { get; set; }
        [Required]
        public int WarningIncrease { get; set; } = 0;
        [Required]
        public long PackId { get; set; }

        // Foreign Keys
        public FilterPack Pack { get; set; }
    }
}
