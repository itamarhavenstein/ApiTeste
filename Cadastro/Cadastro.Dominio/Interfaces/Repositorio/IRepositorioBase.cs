using System.Collections.Generic;

namespace Cadastro
{
    public interface IRepositorioBase<T> where T : class
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(long id);
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Deletar(T entidade);
        void Excluir(long id);
        void Commit();
    }
}
