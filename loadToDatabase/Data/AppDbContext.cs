using System;
using loadToDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace loadToDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AddressData> AddressData { get; set; }

    }
}