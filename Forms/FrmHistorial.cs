using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SunatMCRT.Models;
using SunatMCRT.Services;

namespace SunatMCRT.Forms;

public partial class FrmHistorial : Form
{
    private readonly ServicioComprobantes _servicio;
    private List<Comprobante> _historialCompleto = [];

    public FrmHistorial(ServicioComprobantes servicio)
    {
        _servicio = servicio;
        InitializeComponent();
        ConfigurarHistorialGrid();
        ConfigurarBusqueda();
        CargarHistorial();
    }

    private void ConfigurarBusqueda()
    {
        txtBuscarRuc.PlaceholderText = "Ingrese RUC";
        AcceptButton = btnBuscar;
        txtBuscarRuc.KeyDown += txtBuscarRuc_KeyDown;
    }

    private void txtBuscarRuc_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
        {
            return;
        }

        e.SuppressKeyPress = true;
        FiltrarPorRuc();
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

        dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
        dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.White;
        dgvHistorial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
        dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        dgvHistorial.EnableHeadersVisualStyles = false;
        dgvHistorial.ColumnHeadersHeight = 36;
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    }

    private void CargarHistorial()
    {
        _historialCompleto = _servicio.ObtenerHistorial().ToList();
        MostrarHistorial(_historialCompleto);
        txtBuscarRuc.Focus();
    }

    private void MostrarHistorial(IEnumerable<Comprobante> comprobantes)
    {
        var datos = comprobantes
            .Select(c => new
            {
                Fecha = c.FechaRegistro.ToString("dd/MM/yyyy HH:mm"),
                Tipo = c.TipoComprobante,
                RUC = c.Emisor?.Ruc ?? string.Empty,
                Emisor = c.Emisor?.RazonSocial ?? string.Empty,
                Base = $"S/ {c.MontoBase:N2}",
                Impuesto_Retencion = $"S/ {c.ImpuestoCalculado:N2}",
                Total_Neto = $"S/ {c.MontoTotal:N2}"
            })
            .ToList();

        dgvHistorial.DataSource = datos;
        lblTotalRegistros.Text = $"Total de registros: {datos.Count}";
        lblTotalRegistros.ForeColor = datos.Count == 0 ? Color.Firebrick : SystemColors.ControlText;

        if (datos.Count > 0)
        {
            dgvHistorial.ClearSelection();
        }
    }

    private void FiltrarPorRuc()
    {
        var ruc = txtBuscarRuc.Text.Trim();

        if (string.IsNullOrWhiteSpace(ruc))
        {
            MostrarHistorial(_historialCompleto);
            return;
        }

        var filtrados = _historialCompleto
            .Where(c => (c.Emisor?.Ruc ?? string.Empty).Contains(ruc, StringComparison.OrdinalIgnoreCase))
            .ToList();

        MostrarHistorial(filtrados);

        if (filtrados.Count == 0)
        {
            MessageBox.Show(
                "No se encontraron comprobantes con el RUC indicado.",
                "Sin resultados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        txtBuscarRuc.Clear();
        CargarHistorial();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        FiltrarPorRuc();
    }

    private void btnCerrar_Click(object sender, EventArgs e) => Close();

    private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }
}
