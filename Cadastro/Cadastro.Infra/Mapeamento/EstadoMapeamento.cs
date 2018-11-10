using System.Data.Entity.ModelConfiguration;

namespace Cadastro
{
    public class EstadoMapeamento : EntityTypeConfiguration<Estado>
    {
        public EstadoMapeamento()
        {
            ToTable("Estado");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(x => x.Sigla).HasColumnType("varchar").HasMaxLength(2).IsRequired();
        }
    }
}
