#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EXWebAPI.Model;

namespace EXWebAPI.Data
{
    public class EXWebAPIContext : DbContext
    {
        public EXWebAPIContext (DbContextOptions<EXWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EXWebAPI.Model.Product> Product { get; set; }
    }
}
