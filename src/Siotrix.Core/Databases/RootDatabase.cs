using Microsoft.EntityFrameworkCore;

namespace Siotrix
{
    public class RootDatabase : DbContext
    {
        public DbSet<Community> Communities { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<CommunityConnection> CommunityConnections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CommunityUser> CommunityUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var config = ConfigurationBase.Load<ConfigurationBase>();
            string connection = $"server={config.Server};" +
                $"userid={config.User};" +
                $"pwd={config.Password};" +
                $"port={config.Port};" +
                $"database=root;";
            builder.UseMySql(connection);
        }
    }
}
