using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Data.Configurations
{
    public class BibliotecarioModelConfigurations
    {
        public void Configure(EntityTypeBuilder<BibliotecarioModel> builder)
        {
            builder
                .HasKey(bibl => bibl.Id);
        }
    }
}
