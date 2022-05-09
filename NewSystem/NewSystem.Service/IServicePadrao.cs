using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSystem.Service
{
    public interface IServicePadrao<T>
    {
        string Salvar(T entity);
        string Excluir(T entity);
        T selecionar(int id);
        List<T> SelecionarTodos();
        List<T> Filtrar(string condicao);
     
    }
}
