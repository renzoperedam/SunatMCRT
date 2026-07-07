using SunatMCRT.Models;

namespace SunatMCRT.Abstractions;

public interface IRepositorioComprobante
{
    void Guardar(Comprobante comprobante);
    IEnumerable<Comprobante> ObtenerTodos();
}
