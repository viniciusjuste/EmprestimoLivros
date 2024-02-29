using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {   
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; } // serve para criar a tebela de fato
    }
}
