namespace FinanceControl.UI.Domain.Entities;

public class ContasAPagar : IDisposable
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty!;
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }
    public bool Pago { get; set; } = false;
    public int UsuarioId { get; set; }
    public Usuarios Usuario { get; set; } = new Usuarios();


    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 

    public ContasAPagar()
    {
        DataVencimento = DateTime.Now;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }


    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}