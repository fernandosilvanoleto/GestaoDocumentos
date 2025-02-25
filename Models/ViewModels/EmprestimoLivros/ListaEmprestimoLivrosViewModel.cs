using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models.ViewModels.EmprestimoLivros
{
    public class ListaEmprestimoLivrosViewModel
    {        
        public int IdEmprestimo { get; set; }
        public string NomeEmprestimo { get; set; }
        public string NomeCliente { get; set; }
        public string NomeBibliotecario { get; set; }
        public DateTime DataEvolucao { get; set; }

        public List<LivrosEmprestados> livrosEmprestados = new List<LivrosEmprestados>();
    }
    public class LivrosEmprestados {
        public LivrosEmprestados(string nomeLivro, string statusEmprestimo, DateTime dataHora)
        {
            this.NomeLivro = nomeLivro;
            this.StatusEmprestimo = statusEmprestimo;
            this.DataHora = dataHora;
        }
        public string NomeLivro { get; set; }
        public string StatusEmprestimo { get; set; }
        public DateTime DataHora { get; set; }
    }
}
