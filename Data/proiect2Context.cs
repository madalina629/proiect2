using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proiect2.Models;

namespace proiect2.Data
{
    public class proiect2Context : DbContext
    {
        public proiect2Context (DbContextOptions<proiect2Context> options)
            : base(options)
        {
        }

        public DbSet<proiect2.Models.Food> Food { get; set; }
    }
}
