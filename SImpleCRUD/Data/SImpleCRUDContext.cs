using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SImpleCRUD.Models;

namespace SImpleCRUD.Data
{
    public class SImpleCRUDContext : DbContext
    {
        public SImpleCRUDContext (DbContextOptions<SImpleCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<SImpleCRUD.Models.House> House { get; set; }
    }
}
