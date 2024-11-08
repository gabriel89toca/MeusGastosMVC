using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeusGastosMVC.Models;

namespace MeusGastosMVC.Data
{
    public class MeusGastosMVCContext : DbContext
    {
        public MeusGastosMVCContext (DbContextOptions<MeusGastosMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MeusGastosMVC.Models.Category> Category { get; set; }
    }
}
