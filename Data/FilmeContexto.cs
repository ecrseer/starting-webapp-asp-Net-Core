using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Data
{
  public class FilmeContexto : DbContext
  {
    public FilmeContexto(DbContextOptions
          <FilmeContexto> options) : base(options)
    {
    }

            public DbSet<aspnetcoreapp.Modelos.Filme> Filme { get; set; }

  }
}