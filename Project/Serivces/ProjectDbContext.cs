namespace Project.Serivces
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Project.Models;

    public class ProjectDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDbContext"/> class.
        /// </summary>
        public ProjectDbContext()
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        /// <summary>
        /// Setting work with database.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            try
            {
                var server = "Server=mouse.db.elephantsql.com;Port=5432;Database=hpztmnqc;User Id=hpztmnqc;Password=0tcZi3PIFIxiBna9VoCP_IV_nOq85ZGz;";
                new ConfigurationBuilder()
                              .Build();
                optionsBuilder.UseLazyLoadingProxies()
                              .UseNpgsql(server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}