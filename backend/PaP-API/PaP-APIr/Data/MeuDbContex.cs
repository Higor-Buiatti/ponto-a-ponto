using Microsoft.EntityFrameworkCore;
using PaP_API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PaP_API.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {}

        public DbSet<Ponto> Pontos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Registra os Mapings das classes referenciadas nos DbSets
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            //Configura para que o banco não exclua tabela caso tenha dependencias via foreignKey
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(p => p.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

    }
}
