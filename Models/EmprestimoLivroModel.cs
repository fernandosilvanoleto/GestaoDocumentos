using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class EmprestimoLivroModel
    {
        public int Id { get; set; }
        public int IdEmprestimoCH { get; set; }
        public virtual EmprestimoModel Emprestimo { get; set; }
        public int IdLivroCH { get; set; }
        public virtual LivroModel Livro { get; set; }
        public DateTime DataHoraEmprestimo { get; set; }

        [Required(ErrorMessage = "A Data de Devolução é obrigatório o registro")]
        public DateTime DataDevolucao { get; set; }

        [Required(ErrorMessage = "Por favor! Informe a quantidade de Livro para o empréstimo.")]
        public int QuantidadeAlugadaPorLivro { get; set; }
        public float PrecoUnitarioAlugado { get; set; }
        public string Anotacao { get; set; }
        public bool Ativo { get; set; }
        public int SituacaoAtual { get; set; }
        public bool GerouMulta { get; set; }
        public float? ValorMultaGerada { get; set; }
    }
}
