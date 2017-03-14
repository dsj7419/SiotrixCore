using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class CommunityUser : Entity
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long CommunityId { get; set; }

        // Foreign Keys
        public Community Community { get; set; }
        public User User { get; set; }

        public CommunityUser(long communityId, long userId)
        {
            UserId = userId;
            CommunityId = communityId;
        }
    }
}
