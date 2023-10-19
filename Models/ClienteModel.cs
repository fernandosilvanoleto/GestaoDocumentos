using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Char Sexo { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public List<EmprestimoModel> Emprestimos { get; set; }

    }
}
