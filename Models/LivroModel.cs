using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória")]
        public string Descricao { get; set; }
        public float PrecoUnitario { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "O preço Unitário é obrigatório")]
        public string PrecoUnitarioView { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string ArquivoFile { get; set; }
        public bool Ativo { get; set; }
        public int StatusLivro { get; set; }
        public int TipoLivro { get; set; }
    }
}
