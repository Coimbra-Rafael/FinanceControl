using FinanceControl.UI.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.UI.Infrastructure.Data.Settings;


public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
{
     public void Configure(EntityTypeBuilder<Usuarios> builder)
    {
        builder.ToTable("usuarios");

        builder.HasKey(x => x.Id)
               .HasName("pk_usuarios");

        builder.Property(x => x.Id)
               .HasColumnName("id")
               .UseIdentityAlwaysColumn();

        builder.Property(x => x.Nome)
               .IsRequired()
               .HasColumnName("nome")
               .HasColumnType("varchar(100)");

        builder.Property(x => x.Email)
               .IsRequired()
               .HasColumnName("email")
               .HasColumnType("varchar(100)");

        builder.Property(x => x.CreatedAt)
               .IsRequired()
               .HasColumnName("created_at")
               .HasColumnType("timestamp");

        builder.Property(x => x.UpdatedAt)
               .IsRequired()
               .HasColumnName("updated_at")
               .HasColumnType("timestamp");

        builder.HasIndex(x => x.Email)
               .HasDatabaseName("ix_usuarios_email")
               .IsUnique();
    }
}