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
            builder
                .HasKey(empLivro => empLivro.Id);

            builder
                .HasOne(empLivro => empLivro.Emprestimo)
                .WithMany(emprestimo => emprestimo.LivrosEmprestados)
                .HasForeignKey(empLivro => empLivro.IdEmprestimoCH)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(empLivro => empLivro.Livro)
                .WithMany(livro => livro.LivrosEmprestados)
                .HasForeignKey(empLivro => empLivro.IdLivroCH)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
