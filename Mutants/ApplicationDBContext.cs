using Microsoft.EntityFrameworkCore;
using Mutants.Model;

namespace Mutants
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Mutant> MutantsHistory { get; set; }

    }
}
