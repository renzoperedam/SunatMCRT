using SunatMCRT.Models;
using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmFactura : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmFactura(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
    }

    private void btnProcesar_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtMontoBase.Text, out decimal monto) || monto <= 0)
        {
            MessageBox.Show("Ingrese un monto base válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtRuc.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text))
        {
            MessageBox.Show("Complete el RUC y la razón social.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var factura = new Factura
        {
            Emisor = new Contribuyente { Ruc = txtRuc.Text.Trim(), RazonSocial = txtRazonSocial.Text.Trim() },
            MontoBase = monto
        };

        _servicio.ProcesarYGuardarComprobante(factura);

        lblIgv.Text = $"IGV: S/ {factura.ImpuestoCalculado:N2}";
        lblTotal.Text = $"Total a pagar: S/ {factura.MontoTotal:N2}";
        MessageBox.Show("Factura registrada correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtRuc.Clear();
        txtRazonSocial.Clear();
        txtMontoBase.Clear();
        lblIgv.Text = "IGV: S/ 0.00";
        lblTotal.Text = "Total a pagar: S/ 0.00";
        txtRuc.Focus();
    }

    private bool ValidarRucFactura(string ruc)
    {
        if (string.IsNullOrWhiteSpace(ruc))
        {
            MessageBox.Show("Ingrese el RUC del contribuyente.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (ruc.Length != 11 || !ruc.All(char.IsDigit))
        {
            MessageBox.Show("El RUC debe contener exactamente 11 dígitos numéricos.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;


        }

        return true;
    }

    private void btnCerrar_Click(object sender, EventArgs e) => Close();

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
