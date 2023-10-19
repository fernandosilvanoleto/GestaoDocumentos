using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class DocumentoModel
    {
        public DocumentoModel()
        {
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do documento deve ser informado!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição do documento deve ser informado!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Tipo do documento deve ser informado!")]
        public string TipoDocumento { get; set; }
        public bool Ativo { get; set; }
    }
}
