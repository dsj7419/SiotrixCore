using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Siotrix
{
    public class LogDatabase : DbContext
    {
        public DbSet<Error> Errors { get; set; }
        public DbSet<DiscordMessage> Messages { get; set; }
        public DbSet<DiscordReaction> Reactions { get; set; }
        public DbSet<DiscordMembership> Memberships { get; set; }
        public DbSet<DiscordStatus> Statuses { get; set; }
        public DbSet<DiscordColorInfo> Colorinfos { get; set; }
        public DbSet<DiscordColor> Gcolors { get; set; }
        public DbSet<DiscordGuildFooter> Gfooters { get; set; }
        public DbSet<DiscordAuthor> Authors { get; set; }
        public DbSet<DiscordGuildThumbNail> Gthumbnails { get; set; }
        public DbSet<DiscordGuildSiteUrl> Gwebsiteurls { get; set; }
        public DbSet<DiscordGuildDescription> Gdescriptions { get; set; }
        public DbSet<DiscordGuildName> Gnames { get; set; }
        public DbSet<DiscordSiotrixInfo> Binfos { get; set; }
        public DbSet<DiscordSiotrixSiteUrl> Bwebsiteurls { get; set; }
        public DbSet<DiscordSiotrixFooter> Bfooters { get; set; }
        public DbSet<DiscordGuildAvatar> Gavatars { get; set; }
        public DbSet<DiscordGuildPrefix> Gprefixs { get; set; }
        public DbSet<DiscordGuildMotd> Gmotds { get; set; }
        public DbSet<DiscordGuildToggle> Gtoggles { get; set; }
        public DbSet<DiscordGuildToggleChannel> Gtogglechannels { get; set; }
        public DbSet<DiscordGuildLogChannel> Glogchannels { get; set; }
        public DbSet<DiscordGuildModLogChannel> Gmodlogchannels { get; set; }
        public DbSet<DiscordCaseNum> Casenums { get; set; }
        public DbSet<DiscordGuildMuteRole> Gmuteroles { get; set; }
        public DbSet<DiscordGuildMuteList> Gmutelists { get; set; }
        public DbSet<DiscordGuildSpamInfo> Gspams { get; set; }
        public DbSet<DiscordGuildWarnInfo> Gwarns { get; set; }
        public DbSet<DiscordGuildWarningUser> Gwarningusers { get; set; }
        public DbSet<DiscordGuildFilterList> Gfilterlists { get; set; }
        public DbSet<DiscordBanGuildList> Banguildlists { get; set; }
        public DbSet<DiscordGuildAutoDelete> Gautodeletes { get; set; }
        public DbSet<DiscordGuildAnnounceToggleOrDM> Gannouncetoggles { get; set; }
        public DbSet<DiscordGuildAnnounceMessage> Gannouncemessages { get; set; }
        public DbSet<DiscordGuildAnnounceChannel> Gannouncechannels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var config = ConfigurationBase.Load<ConfigurationBase>();
            string connection = $"server={config.Server};" +
                $"userid={config.User};" +
                $"pwd={config.Password};" +
                $"port={config.Port};" +
                $"database=logs;";
            builder.UseMySql(connection);
        }

        public static Task EnsureExistsAsync()
        {
            using (var db = new LogDatabase())
                return db.Database.EnsureCreatedAsync();
        }

        public Task<DiscordMessage> GetMessageAsync(ulong msgId)
            => Messages.FirstOrDefaultAsync(x => (ulong)x.MessageId == msgId);

        public Task<DiscordReaction> GetReactionAsync(ulong msgId, ulong userId, string name)
            => Reactions.FirstOrDefaultAsync(x => (ulong)x.MessageId == msgId && (ulong)x.AuthorId == userId && x.EmojiName == name);

        public Task<List<DiscordReaction>> GetReactionsAsync(ulong msgId)
            => Reactions.Where(x => (ulong)x.MessageId == msgId).ToListAsync();
    }
}
