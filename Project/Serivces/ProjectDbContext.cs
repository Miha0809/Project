using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.Models;

namespace Project.Serivces;

public class ProjectDbContext : DbContext
{
    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
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