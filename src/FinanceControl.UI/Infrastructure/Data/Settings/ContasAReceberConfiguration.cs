using FinanceControl.UI.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.UI.Infrastructure.Data.Settings;

public class ContasAReceberConfiguration: IEntityTypeConfiguration<ContasAReceber>
{
   public void Configure(EntityTypeBuilder<ContasAReceber> builder)
    {
        builder.ToTable("contas_a_receber");

        builder.HasKey(x => x.Id)
               .HasName("pk_contas_a_receber");

        builder.Property(x => x.Id)
               .HasColumnName("id")
               .UseIdentityAlwaysColumn();

        builder.Property(x => x.Nome)
               .IsRequired()
               .HasColumnName("nome")
               .HasColumnType("varchar(100)");

        builder.Property(x => x.Valor)
               .IsRequired()
               .HasColumnName("valor")
               .HasColumnType("numeric(18,2)");

        builder.Property(x => x.DataVencimento)
               .IsRequired()
               .HasColumnName("data_vencimento")
               .HasColumnType("timestamp");

        builder.Property(x => x.Recebido)
               .IsRequired()
               .HasColumnName("recebido")
               .HasColumnType("boolean")
               .HasDefaultValue(false);

        builder.Property(x => x.UsuarioId)
               .IsRequired()
               .HasColumnName("usuario_id");

        builder.Property(x => x.CreatedAt)
               .IsRequired()
               .HasColumnName("created_at")
               .HasColumnType("timestamp");

        builder.Property(x => x.UpdatedAt)
               .IsRequired()
               .HasColumnName("updated_at")
               .HasColumnType("timestamp");

        builder.HasOne(x => x.Usuario)
               .WithMany()
               .HasForeignKey(x => x.UsuarioId)
               .HasConstraintName("fk_contas_a_receber_usuarios")
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.UsuarioId)
               .HasDatabaseName("ix_contas_a_receber_usuario_id");
    }
}