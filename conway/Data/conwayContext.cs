using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using conway.Models;

namespace conway.Data
{
    public class conwayContext : DbContext
    {
        public conwayContext (DbContextOptions<conwayContext> options)
            : base(options)
        {
        }

        public DbSet<conway.Models.Conway> Conway { get; set; } = default!;
    }
}
