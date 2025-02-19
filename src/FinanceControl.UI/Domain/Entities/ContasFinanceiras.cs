namespace FinanceControl.UI.Domain.Entities;

public class ContasFinanceiras : IDisposable
{
    public int Id { get; set; }
    public string NomeInstituicaoFinanceira { get; set; } = string.Empty!;
    public decimal Saldo { get; set; }
    public decimal LimiteCredito { get; set; }
    public int UsuarioId { get; set; }
    public Usuarios Usuario { get; set; } = new Usuarios();
    
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 

    public ContasFinanceiras()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}