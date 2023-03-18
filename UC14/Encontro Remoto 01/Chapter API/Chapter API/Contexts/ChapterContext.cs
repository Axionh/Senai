using Chapter_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter_API.Contexts
{
    public class ChapterContext : DbContext
        //configuração com o obanco de daos
    {
        public ChapterContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = DESKTOP-O73BAV5\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }

        public DbSet <Livro> Livros { get; set; }
    }
}
