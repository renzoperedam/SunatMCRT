using SunatMCRT.Abstractions;
using SunatMCRT.Models;

namespace SunatMCRT.Repositories;

// SRP: esta clase solo administra el almacenamiento temporal en memoria.
public class RepositorioComprobanteMemoria : IRepositorioComprobante
{
    private readonly List<Comprobante> _comprobantes = new();

    public void Guardar(Comprobante comprobante)
    {
        _comprobantes.Add(comprobante);
    }

    public IEnumerable<Comprobante> ObtenerTodos()
    {
        return _comprobantes;
    }
}
