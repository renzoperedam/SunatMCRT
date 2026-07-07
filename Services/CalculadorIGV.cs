using SunatMCRT.Abstractions;
using SunatMCRT.Models;

namespace SunatMCRT.Services;

// OCP: si aparece un nuevo impuesto, se crea otro calculador sin modificar este.
public class CalculadorIGV : ICalculadorImpuesto
{
    public bool AplicaPara(Comprobante comprobante) => comprobante is Factura;

    public void Calcular(Comprobante comprobante)
    {
        comprobante.ImpuestoCalculado = comprobante.MontoBase * 0.18m;
        comprobante.MontoTotal = comprobante.MontoBase + comprobante.ImpuestoCalculado;
    }
}
