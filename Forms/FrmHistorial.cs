using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmHistorial : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmHistorial(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
        CargarHistorial();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        CargarHistorial();
    }

    private void btnCerrar_Click(object sender, EventArgs e) => Close();

    private void CargarHistorial()
    {
        var datos = _servicio.ObtenerHistorial()
            .Select(c => new
            {
                Fecha = c.FechaRegistro.ToString("dd/MM/yyyy HH:mm"),
                Tipo = c.TipoComprobante,
                RUC = c.Emisor.Ruc,
                Emisor = c.Emisor.RazonSocial,
                Base = $"S/ {c.MontoBase:N2}",
                Impuesto_Retencion = $"S/ {c.ImpuestoCalculado:N2}",
                Total_Neto = $"S/ {c.MontoTotal:N2}"
            })
            .ToList();

        dgvHistorial.DataSource = datos;
        lblTotalRegistros.Text = $"Total de registros: {datos.Count}";
    }

    private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
