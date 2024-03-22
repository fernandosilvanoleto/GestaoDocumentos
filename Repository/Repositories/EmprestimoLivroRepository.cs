using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class EmprestimoLivroRepository : IEmprestimoLivroRepository
    {
        private readonly BancoContext _bancoContext;

        public EmprestimoLivroRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EmprestimoLivroModel AdicionarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public bool AjustarStatusEmprestimoLivro(int idEmprestimoLivro, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> BuscarTodosEmprestimosLivro()
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> BuscarTodosEmprestimosLivroAtivos()
        {
            throw new NotImplementedException();
        }

        public EmprestimoLivroModel EditarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> ListaPorIdEmprestimo(int idEmprestimo)
        {
            throw new NotImplementedException();
        }

        public EmprestimoLivroModel ListaPorIdEmprestimoLivro(int idEmprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> ListaPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
