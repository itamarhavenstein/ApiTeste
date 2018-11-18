namespace Cadastro
{
    public class CidadeRepositorio : RepositorioBase<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(PessoaContexto _contexto) : base(_contexto)
        {
        }
    }
}
