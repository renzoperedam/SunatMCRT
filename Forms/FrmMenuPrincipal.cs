using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmMenuPrincipal : Form
{
    private readonly ServicioComprobantes _servicio;

    public FrmMenuPrincipal(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
    }

    private void btnFactura_Click(object sender, EventArgs e)
    {
        using var frm = new FrmFactura(_servicio);
        frm.ShowDialog(this);
    }

    private void btnRecibo_Click(object sender, EventArgs e)
    {
        using var frm = new FrmReciboHonorario(_servicio);
        frm.ShowDialog(this);
    }

    private void btnHistorial_Click(object sender, EventArgs e)
    {
        using var frm = new FrmHistorial(_servicio);
        frm.ShowDialog(this);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
