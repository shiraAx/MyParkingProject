using _3_Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Interfaces
{
    public interface IDataSource
    {
        public DbSet<Complaints>  Complaints { get; set; }
        public DbSet<Park> Parks { get; set; }   
        public DbSet<PurchasePoints> PurchasePoints { get; set; }
        public DbSet <RecentUses> RecentUses { get; set; }
        public DbSet<SharedParking> SharedParkings { get; set; }
        public DbSet<User> Users { get; set; }   
        public DbSet<VehicleDetails> VehiclesDetails { get; set; }
        Task<int> SaveChanges(CancellationToken cancellationToken = default(CancellationToken));

    }
}
