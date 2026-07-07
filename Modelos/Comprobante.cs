namespace SunatMCRT.Models;

public abstract class Comprobante
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Contribuyente Emisor { get; set; } = new();
    public decimal MontoBase { get; set; }
    public decimal ImpuestoCalculado { get; set; }
    public decimal MontoTotal { get; set; }
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
    public abstract string TipoComprobante { get; }
}
