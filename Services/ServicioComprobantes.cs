using SunatMCRT.Abstractions;
using SunatMCRT.Models;

namespace SunatMCRT.Services;

// SRP: esta clase solo procesa comprobantes y coordina calculadores/repositorio.
// DIP: depende de IRepositorioComprobante e ICalculadorImpuesto, no de clases concretas.
public class ServicioComprobantes
{
    private readonly IRepositorioComprobante _repositorio;
    private readonly IEnumerable<ICalculadorImpuesto> _calculadores;

    public ServicioComprobantes(IRepositorioComprobante repositorio, IEnumerable<ICalculadorImpuesto> calculadores)
    {
        _repositorio = repositorio;
        _calculadores = calculadores;
    }

    public void ProcesarYGuardarComprobante(Comprobante comprobante)
    {
        var calculador = _calculadores.FirstOrDefault(c => c.AplicaPara(comprobante));
        if (calculador is null)
        {
            throw new InvalidOperationException("No existe un calculador para este tipo de comprobante.");
        }

        calculador.Calcular(comprobante);
        _repositorio.Guardar(comprobante);
    }

    public IEnumerable<Comprobante> ObtenerHistorial()
    {
        return _repositorio.ObtenerTodos();
    }
}
