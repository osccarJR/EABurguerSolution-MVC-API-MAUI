using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EABurguerSolution.Models;

namespace EABurguerSolution.Data
{
    public class EABurguerSolutionContext : DbContext
    {
        public EABurguerSolutionContext (DbContextOptions<EABurguerSolutionContext> options)
            : base(options)
        {
        }

        public DbSet<EABurguerSolution.Models.Promo> Promo { get; set; } = default!;
        public DbSet<EABurguerSolution.Models.Burguer> Burguer { get; set; } = default!;
    }
}
