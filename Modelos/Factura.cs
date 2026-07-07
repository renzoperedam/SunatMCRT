namespace SunatMCRT.Models;

public class Factura : Comprobante
{
    public override string TipoComprobante => "Factura (IGV)";
}
