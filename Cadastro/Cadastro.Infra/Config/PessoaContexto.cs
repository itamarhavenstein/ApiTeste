using System.Data.Entity;

namespace Cadastro
{
    public class PessoaContexto : DbContext
    {
        public PessoaContexto() : base("default")
        {
            var ensure = System.Data.Entity.SqlServer.SqlProviderServices.UseScopeIdentity;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CidadeMapeamento());
            //modelBuilder.Configurations.Add(new EstadoMapeamento());
            //modelBuilder.Configurations.Add(new EnderecoMapeamento());
            //modelBuilder.Configurations.Add(new PessoaMapeamento());
        }
    }
}
