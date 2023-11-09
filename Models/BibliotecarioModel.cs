using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoDocumentos.Models
{
    public class BibliotecarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public List<EmprestimoModel> Emprestimos { get; set; }
    }
}
