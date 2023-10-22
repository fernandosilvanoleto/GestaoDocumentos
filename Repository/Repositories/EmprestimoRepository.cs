using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        public EmprestimoModel AdicionarEmprestimo(EmprestimoModel emprestimo)
        {
            throw new NotImplementedException();
        }

        public bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public bool AjustarStatusEmprestimo(int idEmprestimo, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoModel> BuscarTodosEmprestimos()
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoModel> BuscarTodosEmprestimosAtivos()
        {
            throw new NotImplementedException();
        }

        public EmprestimoModel EditarEmprestimo(EmprestimoModel emprestimo)
        {
            throw new NotImplementedException();
        }

        public EmprestimoModel ListaPorIdBibliotecarioEmprestimos(int IdBibliotecario)
        {
            throw new NotImplementedException();
        }

        public EmprestimoModel ListaPorIdClientesEmprestimos(int idCliente)
        {
            throw new NotImplementedException();
        }

        public EmprestimoModel ListaPorIdEmprestimo(int idEmprestimo)
        {
            throw new NotImplementedException();
        }
    }
}
