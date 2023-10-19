using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GestaoDocumentos.Data
{
    public class BancoContext : DbContext
    {
        public DbSet<DocumentoModel> Documentos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<BibliotecarioModel> Bilbiotecarios { get; set; }
        public DbSet<EmprestimoModel> Emprestimos { get; set; }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BUSCAR TODAS AS CONFIGURATIONS DA PASTA CONFIGURATIONS
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}
