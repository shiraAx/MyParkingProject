using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories
{
    public class SQLDataSource : DbContext, IDataSource
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER001\\Documents\\myParkingsDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        public DbSet<Complaints> Complaints { get ; set ; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<PurchasePoints> PurchasePoints { get; set; }
        public DbSet<RecentUses> RecentUses { get; set; }
        public DbSet<SharedParking> SharedParkings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleDetails> VehiclesDetails { get; set; }

        public async Task<int> SaveChanges(CancellationToken cancellationToken = default)
        {
            return base.SaveChanges();
        }
    }
}
