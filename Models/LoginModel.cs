using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o e-mail do cliente")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-mail informado é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do cliente")]
        public string Senha { get; set; }
    }
}
