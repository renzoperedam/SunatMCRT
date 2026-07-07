using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmNotaCredito : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmNotaCredito(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtMonto.Text, out var monto) || monto <= 0)
        {
            MessageBox.Show("Ingrese un monto válido.");
            return;
        }

        var baseImponible = monto / 1.18m;
        var igv = monto - baseImponible;

        txtBase.Text = baseImponible.ToString("0.00");
        txtIGV.Text = igv.ToString("0.00");
        txtTotal.Text = monto.ToString("0.00");
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtComprobante.Text) ||
            string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show("Complete los datos obligatorios.");
            return;
        }

        MessageBox.Show("Nota de Crédito registrada correctamente.",
            "SUNAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        foreach (Control c in Controls)
            if (c is TextBox t) t.Clear();

        cboMotivo.SelectedIndex = -1;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
