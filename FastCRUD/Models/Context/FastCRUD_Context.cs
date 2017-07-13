using FastCRUD.Models.Mappings;
using System.Data.Entity;

namespace FastCRUD.Models.Context
{
    public class FastCRUD_Context : DbContext
    {

        //Modifica o nome na base de dados
        public FastCRUD_Context() : base("FastCRUD")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMappings());

            base.OnModelCreating(modelBuilder);
        }

    }
}