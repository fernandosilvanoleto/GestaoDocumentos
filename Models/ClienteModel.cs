using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Char Sexo { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public List<EmprestimoModel> Emprestimos { get; set; }

    }
}
