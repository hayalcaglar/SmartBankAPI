﻿using Microsoft.EntityFrameworkCore;

namespace SmartBankAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

    }
}
