using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ErrorReport.Data
{
    public class FelanmälanWebApiContext : DbContext
    {
        public FelanmälanWebApiContext(DbContextOptions<FelanmälanWebApiContext> option) : base(option) { }

        public DbSet<Report> Felanmälningar { get; set; } = default!;

    }
}
