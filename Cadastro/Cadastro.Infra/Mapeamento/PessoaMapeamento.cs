using System.Data.Entity.ModelConfiguration;

namespace Cadastro
{
    public class PessoaMapeamento :  EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapeamento()
        {
            ToTable("Pessoa");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(x => x.Cpf).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            Property(x => x.Rg).HasColumnType("varchar").HasMaxLength(10).IsRequired();

            HasRequired(x => x.Enderecos).WithMany().HasForeignKey(x => x.IdEndereco);
        }
    }
}
