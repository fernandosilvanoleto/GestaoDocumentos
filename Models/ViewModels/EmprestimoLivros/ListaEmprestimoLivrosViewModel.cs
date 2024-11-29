using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models.ViewModels.EmprestimoLivros
{
    public class ListaEmprestimoLivrosViewModel
    {
        public ListaEmprestimoLivrosViewModel()
        {

        }
        public ListaEmprestimoLivrosViewModel(int idEmprestimo, string nomeEmprestimo)
        {
            IdEmprestimo = idEmprestimo;
            NomeEmprestimo = nomeEmprestimo;
        }
        public int IdEmprestimo { get; set; }
        public string NomeEmprestimo { get; set; }
    }
}
