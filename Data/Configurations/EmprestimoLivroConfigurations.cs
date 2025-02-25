using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Data.Configurations
{
    public class EmprestimoLivroConfigurations
    {
        public void Configure(EntityTypeBuilder<EmprestimoLivroModel> builder)
        {
            builder.HasKey(empLivro => empLivro.Id);

            builder
                .HasOne(empLivro => empLivro.Emprestimo)
                .WithMany(emprestimo => emprestimo.LivrosEmprestados)
                .HasForeignKey(empLivro => empLivro.IdEmprestimoCH) // Definindo a chave correta
                .HasPrincipalKey(emprestimo => emprestimo.Id) // Dizendo ao EF que o relacionamento é com o campo Id do Emprestimo
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(empLivro => empLivro.Livro)
                .WithMany(livro => livro.LivrosEmprestados)
                .HasForeignKey(empLivro => empLivro.IdLivroCH) // Definindo a chave correta
                .HasPrincipalKey(livro => livro.Id) // Dizendo ao EF que o relacionamento é com o campo Id do Livro
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
