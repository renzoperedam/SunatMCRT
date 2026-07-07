using SunatMCRT.Models;
using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmReciboHonorario : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmReciboHonorario(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
    }

    private void btnProcesar_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtMontoBase.Text, out decimal monto) || monto <= 0)
        {
            MessageBox.Show("Ingrese un monto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtRuc.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text))
        {
            MessageBox.Show("Complete el RUC y el nombre o razón social.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var recibo = new ReciboHonorario
        {
            Emisor = new Contribuyente { Ruc = txtRuc.Text.Trim(), RazonSocial = txtRazonSocial.Text.Trim() },
            MontoBase = monto
        };

        _servicio.ProcesarYGuardarComprobante(recibo);

        lblRetencion.Text = $"Retención 4ta categoría: S/ {recibo.ImpuestoCalculado:N2}";
        lblNeto.Text = $"Neto a recibir: S/ {recibo.MontoTotal:N2}";
        MessageBox.Show("Recibo registrado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtRuc.Clear(); txtRazonSocial.Clear(); txtMontoBase.Clear();
        lblRetencion.Text = "Retención 4ta categoría: S/ 0.00";
        lblNeto.Text = "Neto a recibir: S/ 0.00";
        txtRuc.Focus();
    }

    private void btnCerrar_Click(object sender, EventArgs e) => Close();

}
