using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class GameStoreDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameStoreDBContext;Trusted_Connection=true");
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
    }
}