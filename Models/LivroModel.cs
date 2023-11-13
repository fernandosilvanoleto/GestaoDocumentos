using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float PrecoUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string ArquivoFile { get; set; }
        public bool Ativo { get; set; }
        public int StatusLivro { get; set; }
        public int TipoLivro { get; set; }
    }
}
