using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Data.Configurations
{
    public class ClienteModelConfigurations
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder
                .HasKey(cliente => cliente.Id);
        }
    }
}
