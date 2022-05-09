using System.Linq;

namespace NewSystem.Repository.Interfaces
{
    public interface IPadraoRepository<T> where T : class
    {        
        string Incluir(T entity);
        string Alterar(T entity);
        string Excluir(T entity);
        T Selecionar(int id);
        IQueryable<T> SelecionarTodos();
        IQueryable<T> Filtrar(string condicao);
    }
}
