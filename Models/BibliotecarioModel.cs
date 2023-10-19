using System.Collections.Generic;

namespace GestaoDocumentos.Models
{
    public class BibliotecarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<EmprestimoModel> Emprestimos { get; set; }
    }
}
