using SunatMCRT.Abstractions;
using SunatMCRT.Forms;
using SunatMCRT.Repositories;
using SunatMCRT.Services;

namespace SunatMCRT;

internal static class Program
{
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        IRepositorioComprobante repositorio = new RepositorioComprobanteMemoria();
        IEnumerable<ICalculadorImpuesto> calculadores = new List<ICalculadorImpuesto>
        {
            new CalculadorIGV(),
            new CalculadorRentaCuarta()
        };

        var servicio = new ServicioComprobantes(repositorio, calculadores);
        Application.Run(new FrmMenuPrincipal(servicio));
    }
}
