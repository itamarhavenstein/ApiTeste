using System.Data.Entity.ModelConfiguration;

namespace Cadastro
{
    public class EnderecoMapeamento : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapeamento()
        {
            ToTable("Endereco");
            HasKey(x => x.Id);

            Property(x => x.Bairro).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(x => x.Numero).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            Property(x => x.Rua).HasColumnType("varchar").HasMaxLength(50).IsRequired();

            HasRequired(x => x.Cidades).WithMany().HasForeignKey(x => x.IdCidade);
            HasRequired(x => x.Estados).WithMany().HasForeignKey(x => x.IdEstado);
        }
    }
}
