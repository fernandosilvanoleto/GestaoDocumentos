using GestaoDocumentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface IEmprestimoRepository
    {
        List<EmprestimoModel> BuscarTodosEmprestimos();
        List<EmprestimoModel> BuscarTodosEmprestimosAtivos();
        EmprestimoModel ListaPorIdEmprestimo(int idEmprestimo);
        List<EmprestimoModel> ListaPorIdClientesEmprestimos(int idCliente);
        List<EmprestimoModel> ListaPorIdBibliotecarioEmprestimos(int IdBibliotecario);
        EmprestimoModel EditarEmprestimo(EmprestimoModel emprestimo);
        EmprestimoModel AdicionarEmprestimo(EmprestimoModel emprestimo);
        bool AjustarStatusEmprestimo(int idEmprestimo, int opcaoStatus);
        bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus);

    }
}
