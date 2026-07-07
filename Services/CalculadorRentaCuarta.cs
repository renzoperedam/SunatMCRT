using SunatMCRT.Abstractions;
using SunatMCRT.Models;

namespace SunatMCRT.Services;

// OCP: esta regla se agrega como extensión mediante la interfaz ICalculadorImpuesto.
public class CalculadorRentaCuarta : ICalculadorImpuesto
{
    public bool AplicaPara(Comprobante comprobante) => comprobante is ReciboHonorario;

    public void Calcular(Comprobante comprobante)
    {
        if (comprobante.MontoBase > 1500m)
        {
            comprobante.ImpuestoCalculado = comprobante.MontoBase * 0.08m;
            comprobante.MontoTotal = comprobante.MontoBase - comprobante.ImpuestoCalculado;
        }
        else
        {
            comprobante.ImpuestoCalculado = 0m;
            comprobante.MontoTotal = comprobante.MontoBase;
        }
    }
}
