using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APBD_12.Models;

namespace APBD_12.Data
{
    public class APBD_12Context : DbContext
    {
        public APBD_12Context (DbContextOptions<APBD_12Context> options)
            : base(options)
        {
        }

        public DbSet<APBD_12.Models.Movie> Movie { get; set; } = default!;
    }
}
