using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDocumentos.Data.Configurations
{
    public class EmprestimoModelConfigurations
    {
        public void Configure(EntityTypeBuilder<EmprestimoModel> builder)
        {
            builder
                .HasKey(emp => emp.Id);

            builder
                .HasOne(emp => emp.Cliente)
                .WithMany(cliente => cliente.Emprestimos)
                .HasForeignKey(emp => emp.IdClienteCH)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(emp => emp.Bibliotecario)
                .WithMany(biblio => biblio.Emprestimos)
                .HasForeignKey(emp => emp.IdBibliotecarioCH)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
