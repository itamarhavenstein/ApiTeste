namespace Cadastro
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {

        private PessoaContexto contexto = null;
        private CidadeRepositorio cidade = null;

        public ICidadeRepositorio cidadeRepositorio
        {
            get
            {
                if(cidade == null)
                {
                    cidade = new CidadeRepositorio(contexto);
                }
                return cidade;
            }
        }
    }
}
