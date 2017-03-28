using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ferdis.Models;

namespace ferdis.DAL
{
    public class FerdiDBContext : DbContext
    {
        public FerdiDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemInventory> ItemInventory { get; set; }
    }
}
