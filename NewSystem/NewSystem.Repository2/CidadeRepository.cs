using NewSystem.Entity;
using NewSystem.Infrastructure;
using NewSystem.Repository.Interfaces;
using System;
using System.Linq;

namespace NewSystem.Repository
{
    public class CidadeRepository : IPadraoRepository<Cidade>, IDisposable
    {
        private NewSystemContext _context = new NewSystemContext();
        private IRepository<Cidade> _repository;

        public CidadeRepository(NewSystemContext context = null)
        {
            _repository = new Repository<Cidade>(context ?? new NewSystemContext());
        }        

        public string Incluir(Cidade entity)
        {
            var mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }
        public string Alterar(Cidade entity)
        {
            var mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }        

        public string Excluir(Cidade entity)
        {
            var mensagem = ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity);
            }
            return mensagem;
        }
       

        public IQueryable<Cidade> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }        

        public Cidade Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Cidade> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public string ValidarDados(Cidade entity)
        {
            if (string.IsNullOrEmpty(entity.Descricao))
                return "Descrição da cidade não informada!";
            else if (entity.CodigoIBGE == 0)
                return "Código IBGE não informado!";
            else if (entity.EstadoId == 0)
                return "Estado não informado!";
            else
                return "";

        }

        public string ValidarExclusao(Cidade entity)
        {
            if ((from q in _context.Pessoas where q.CidadeId == entity.Id select q).Count() != 0)
                return "Não é possivel excluir essa cidade pois a mesma está vinculado à Pessoa(s)";
            return "";
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
