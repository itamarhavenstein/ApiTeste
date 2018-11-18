using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Cadastro
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private PessoaContexto Contexto { get; set; }

        public RepositorioBase(PessoaContexto _contexto)
        {
            Contexto = _contexto;
        }

        public void Alterar(T entidade)
        {
            Contexto.Entry(entidade).State = EntityState.Modified;
        }

        public T BuscarPorId(long id)
        {
            var retorno = Contexto.Set<T>().Find(id);
            return retorno;
        }

        public IEnumerable<T> BuscarTodos()
        {
            var retorno = Contexto.Set<T>().ToList();
            return retorno;
        }

        public void Commit()
        {
            Contexto.SaveChanges();
        }

        public void Deletar(T entidade)
        {
            Contexto.Entry(entidade).State = EntityState.Deleted;
        }

        public void Excluir(long id)
        {
            var entity = Contexto.Set<T>().Find(id);
            Contexto.Set<T>().Remove(entity);
        }

        public void Inserir(T entidade)
        {
            Contexto.Entry(entidade).State = EntityState.Added;
        }
    }
}
