using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        public int IdClienteCH { get; set; }
        public ClienteModel Cliente { get; set; }
        public int IdBibliotecarioCH { get; set; }
        public BibliotecarioModel Bibliotecario { get; set; }
        public string NomePersonalizado { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Observacao { get; set; }
        public string StatusEmprestimo { get; set; }
        public bool Ativo { get; set; }

        public List<EmprestimoLivroModel> LivrosEmprestados { get; set; }

        [NotMapped]
        public string LivrosEmprestadosModel_View { get; set; }



    }
}
