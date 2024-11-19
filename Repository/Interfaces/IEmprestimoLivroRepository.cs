using GestaoDocumentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface IEmprestimoLivroRepository
    {
        List<EmprestimoLivroModel> BuscarTodosEmprestimosLivro();
        List<EmprestimoLivroModel> BuscarTodosEmprestimosLivroAtivos();
        EmprestimoLivroModel ListaPorIdEmprestimoLivro(int idEmprestimoLivro);
        List<EmprestimoLivroModel> ListaPorIdLivro(int idLivro);
        List<EmprestimoLivroModel> ListaPorIdEmprestimo(int idEmprestimo);
        EmprestimoLivroModel EditarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro);
        EmprestimoLivroModel AdicionarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro);
        bool AdicionarListaEmprestimoLivro(List<EmprestimoLivroModel> emprestimoLivroModels);
        bool AjustarStatusEmprestimoLivro(int idEmprestimoLivro, int opcaoStatus);
        bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus);
    }
}
