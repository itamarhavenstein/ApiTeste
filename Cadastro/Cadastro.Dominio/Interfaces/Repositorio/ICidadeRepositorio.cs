namespace Cadastro
{
    public interface ICidadeRepositorio : IRepositorioBase<Cidade>
    {
        bool BuscarPorNome(string nome);
    }
}
