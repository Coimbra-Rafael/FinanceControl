namespace FinanceControl.UI.Domain.Entities;

public class Usuarios : IDisposable
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty!;
    public string Email { get; set; } = string.Empty!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Usuarios()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}