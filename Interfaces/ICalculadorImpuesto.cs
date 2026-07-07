using SunatMCRT.Models;

namespace SunatMCRT.Abstractions;

public interface ICalculadorImpuesto
{
    bool AplicaPara(Comprobante comprobante);
    void Calcular(Comprobante comprobante);
}
