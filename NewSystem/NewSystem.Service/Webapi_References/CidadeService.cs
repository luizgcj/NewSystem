using NewSystem.Entity;
using System.Collections.Generic;

namespace NewSystem.Service.Webapi_References
{
    public class CidadeService : IServicePadrao<Cidade>
    {
        private string _url;

        public CidadeService(string url)
        {
            _url = url;
        }

        public string Excluir(Cidade entity)
        {
            return WebApiSerializer.HttpPost<Cidade, string>(entity, _url, "excluir");
        }

        public List<Cidade> Filtrar(string condicao)
        {
            return WebApiSerializer.HttpGet<List<Cidade>>(_url, $"filtrar?condicao={condicao}");
        }

        public string Salvar(Cidade entity)
        {
            return WebApiSerializer.HttpPost<Cidade, string>(entity, _url, "salvar");
        }

        public Cidade selecionar(int id)
        {
            return WebApiSerializer.HttpGet<Cidade>(_url, $"selecionar/{id}");
        }

        public List<Cidade> SelecionarTodos()
        {
            return WebApiSerializer.HttpGet<List<Cidade>>(_url, "selecionartodos");
        }
    }
}
