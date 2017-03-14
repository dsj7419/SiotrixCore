using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class CommunityConnection : Entity
    {
        [Required]
        public long ConnectionId { get; set; }
        [Required]
        public long CommunityId { get; set; }

        // Foreign Keys
        public Community Community { get; set; }
        public Connection Connection { get; set; }

        public CommunityConnection(long communityId, long connectionId)
        {
            ConnectionId = connectionId;
            CommunityId = communityId;
        }
    }
}
