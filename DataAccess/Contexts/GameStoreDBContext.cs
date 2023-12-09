using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class GameStoreDBContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }

        public GameStoreDBContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); }
    }
}