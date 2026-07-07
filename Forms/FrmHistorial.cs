using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmHistorial : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmHistorial(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
        ConfigurarHistorialGrid();
        CargarHistorial();
    }

    private void ConfigurarHistorialGrid()
    {
        dgvHistorial.ReadOnly = true;
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHistorial.MultiSelect = false;
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AllowUserToDeleteRows = false;
        dgvHistorial.AllowUserToResizeRows = false;
        dgvHistorial.RowHeadersVisible = false;
        dgvHistorial.AutoGenerateColumns = true;

        dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        dgvHistorial.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
        dgvHistorial.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        dgvHistorial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        dgvHistorial.EnableHeadersVisualStyles = false;
        dgvHistorial.ColumnHeadersHeight = 36;
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
