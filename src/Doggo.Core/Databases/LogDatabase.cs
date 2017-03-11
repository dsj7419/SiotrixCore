using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Doggo
{
    public class LogDatabase : DbContext
    {
        public DbSet<Error> Errors { get; set; }
        public DbSet<DiscordMessage> Messages { get; set; }
        public DbSet<DiscordReaction> Reactions { get; set; }
        public DbSet<DiscordMembership> Memberships { get; set; }
        public DbSet<DiscordStatus> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var config = ConfigurationBase.Load<ConfigurationBase>();
            string connection = $"server={config.Server};userid={config.User};pwd={config.Password};port={config.Port};database=logs;";
            builder.UseMySql(connection);
        }

        public static Task EnsureExistsAsync()
        {
            using (var db = new LogDatabase())
                return db.Database.EnsureCreatedAsync();
        }

        public Task<DiscordMessage> GetMessageAsync(ulong msgId)
            => Messages.FirstOrDefaultAsync(x => (ulong)x.MessageId == msgId);

        public Task<DiscordReaction> GetReactionAsync(ulong userId, string name)
            => Reactions.FirstOrDefaultAsync(x => (ulong)x.AuthorId == userId && x.EmojiName == name);
    }
}
