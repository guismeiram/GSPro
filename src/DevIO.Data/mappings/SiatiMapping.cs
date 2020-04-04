using DevIO.Bussines.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.mappings
{
    public class SiatiMapping : IEntityTypeConfiguration<Siati>
    {
        public void Configure(EntityTypeBuilder<Siati> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Resolucao).IsRequired().HasColumnType("varchar(500)");

            builder.Property(p => p.TipoProcesso).IsRequired().HasColumnType("varchar(100)");

            builder.Property(p => p.NumeroProcesso).IsRequired().HasColumnType("varchar(100)");
            
            builder.Property(p => p.NomeProcesso).IsRequired().HasColumnType("varchar(100)");

            builder.Property(p => p.NomeUser).IsRequired().HasColumnType("varchar(100)");


          

            builder.ToTable("Siatis");
        }
    }
}
