using Microsoft.EntityFrameworkCore;

namespace net_core_api_sabnis.Models
{
  public class ApplicationContext  : DbContext
  {
      public ApplicationContext (DbContextOptions opts) : base(opts)
      {
      }

      public DbSet<Book> Books { get; set; }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
      }
  }
}