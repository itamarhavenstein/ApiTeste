using System.Data.Entity.ModelConfiguration;

namespace Cadastro
{
    public class CidadeMapeamento : EntityTypeConfiguration<Cidade>
    {
        public CidadeMapeamento()
        {
            ToTable("Cidade");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(35).IsRequired();
        }
    }
}
