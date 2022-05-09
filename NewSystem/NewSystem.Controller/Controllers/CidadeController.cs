using NewSystem.Entity;
using NewSystem.Infrastructure;
using NewSystem.Repository;
using NewSystem.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NewSystem.Controller.Controllers
{
    [RoutePrefix("api/cidade")]
    public class CidadeController : ApiController, IServicePadrao<Cidade>
    {
        private string _mensagem = "";
        public string Excluir(Cidade entity)
        {
            using (var contexto = new NewSystemContext())
            {
                using (var transacao = NewSystemTransaction.CreateDbContextTransaction(contexto))
                {
                    _mensagem = new CidadeRepository(contexto).Excluir(entity);

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }

            }
            return _mensagem;
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Cidade> Filtrar(string condicao)
        {
            List<Cidade> cidades = new CidadeRepository().Filtrar(condicao).ToList();            
            return cidades;
        }

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Cidade entity)
        {
            using (var contexto = new NewSystemContext())
            {
                using (var transacao = NewSystemTransaction.CreateDbContextTransaction(contexto))
                {
                    if (entity.Id == 0)
                        _mensagem = new CidadeRepository(contexto).Incluir(entity);
                    else
                        _mensagem = new CidadeRepository(contexto).Alterar(entity);

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpGet]
        [Route("selecionar/{id}")]
        public Cidade selecionar(int id)
        {
            return new CidadeRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Cidade> SelecionarTodos()
        {
            return new CidadeRepository().SelecionarTodos().ToList();
        }
    }
}
