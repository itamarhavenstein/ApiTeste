namespace Cadastro
{
    public class CidadeAdaptador
    {
        public void AdaptInserir(CidadeDTO origem, Cidade destino)
        {
            destino.Nome = origem.Nome;
        }

        public void AdaptAlterar(CidadeDTO origem, Cidade destino)
        {
            destino.Nome = origem.Nome;
        }

        public void AdaptBusca(Cidade origem, CidadeDTO destino)
        {
            destino.Id = origem.Id;
            destino.Nome = origem.Nome;
        }
    }
}
