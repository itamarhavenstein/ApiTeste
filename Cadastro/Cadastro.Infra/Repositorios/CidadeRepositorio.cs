using System.Linq;

namespace Cadastro
{
    public class CidadeRepositorio : RepositorioBase<Cidade>, ICidadeRepositorio
    {
        private PessoaContexto db;
        public CidadeRepositorio(PessoaContexto _contexto) : base(_contexto)
        {
            db = _contexto;
        }

        public bool BuscarPorNome(string nome)
        {
            var resposta = db.Set<Cidade>().Where(x => x.Nome == nome).FirstOrDefault();
            if (resposta != null)
                return false;
            return true;
        }
    }
}
