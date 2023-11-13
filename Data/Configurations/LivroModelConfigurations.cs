using GestaoDocumentos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Data.Configurations
{
    public class LivroModelConfigurations
    {
        public void Configure(EntityTypeBuilder<LivroModel> builder)
        {
            builder
                .HasKey(lvo => lvo.Id);
        }
    }
}
