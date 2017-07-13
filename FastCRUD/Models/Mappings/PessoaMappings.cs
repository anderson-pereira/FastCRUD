using System.Data.Entity.ModelConfiguration;

namespace FastCRUD.Models.Mappings
{
    public class PessoaMappings : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMappings()
        {
            ToTable("Pessoa");

            HasKey(x => x.ID);

            Property(x => x.Nome).HasMaxLength(60);

            Property(x => x.email).HasMaxLength(60);
        }
    }
}