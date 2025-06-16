using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiagetMicroserv.Models;

namespace PiagetMicroserv.Data
{
    public class PiagetMicroservContext : DbContext
    {
        public PiagetMicroservContext (DbContextOptions<PiagetMicroservContext> options)
            : base(options)
        {
        }

        public DbSet<PiagetMicroserv.Models.Produtos> Produtos { get; set; } = default!;
        public DbSet<PiagetMicroserv.Models.Fornecedor> Fornecedor { get; set; } = default!;
    }
}
