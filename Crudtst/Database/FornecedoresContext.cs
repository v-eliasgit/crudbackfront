using Crudtst.Models;
using Microsoft.EntityFrameworkCore;

namespace Crudtst.Database
{
    public class FornecedoresContext : DbContext
    {
        public FornecedoresContext(DbContextOptions<FornecedoresContext> options) : base(options)
        {

        }

        public DbSet<Fornecedores> Fornecedores { get; set; }
    }
}
