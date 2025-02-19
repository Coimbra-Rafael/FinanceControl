using FinanceControl.UI.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.UI.Infrastructure.Data.Settings;

public class ContasFinanceirasConfiguration: IEntityTypeConfiguration<ContasFinanceiras>
{
    public void Configure(EntityTypeBuilder<ContasFinanceiras> builder)
    {
        builder.ToTable("contas_financeiras");

        builder.HasKey(x => x.Id)
               .HasName("pk_contas_financeiras");

        builder.Property(x => x.Id)
               .HasColumnName("id")
               .UseIdentityAlwaysColumn();

        builder.Property(x => x.NomeInstituicaoFinanceira)
               .IsRequired()
               .HasColumnName("nome_instituicao_financeira")
               .HasColumnType("varchar(100)");

        builder.Property(x => x.Saldo)
               .IsRequired()
               .HasColumnName("saldo")
               .HasColumnType("numeric(18,2)")
               .HasDefaultValue(0);

        builder.Property(x => x.LimiteCredito)
               .IsRequired()
               .HasColumnName("limite_credito")
               .HasColumnType("numeric(18,2)")
               .HasDefaultValue(0);

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
               .HasConstraintName("fk_contas_financeiras_usuarios")
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.UsuarioId)
               .HasDatabaseName("ix_contas_financeiras_usuario_id");
    }
}