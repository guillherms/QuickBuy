﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Haskey:  Define qual propriedade de usuario que vai atuar como chave primaria
            builder.HasKey(u => u.Id);
            //Builder utiliza o padrão fluente
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(600);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
