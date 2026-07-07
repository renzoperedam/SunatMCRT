namespace SunatMCRT.Forms;

partial class FrmNotaCredito
{
    private TextBox txtComprobante;
    private TextBox txtCliente;
    private TextBox txtMonto;
    private TextBox txtBase;
    private TextBox txtIGV;
    private TextBox txtTotal;

    private ComboBox cboMotivo;

    private Button btnCalcular;
    private Button btnGuardar;
    private Button btnLimpiar;
    private Button btnSalir;


    private void InitializeComponent()
    {
        txtComprobante = new TextBox();
        txtCliente = new TextBox();
        txtMonto = new TextBox();
        txtBase = new TextBox();
        txtIGV = new TextBox();
        txtTotal = new TextBox();
        cboMotivo = new ComboBox();
        btnCalcular = new Button();
        btnGuardar = new Button();
        btnLimpiar = new Button();
        btnSalir = new Button();
        lblComprobante = new Label();
        lblCliente = new Label();
        lblMotivo = new Label();
        lblMonto = new Label();
        lblBase = new Label();
        lblIGV = new Label();
        lblTotal = new Label();
        SuspendLayout();
        // 
        // txtComprobante
        // 
        txtComprobante.Location = new Point(200, 25);
        txtComprobante.Name = "txtComprobante";
        txtComprobante.Size = new Size(220, 27);
        txtComprobante.TabIndex = 1;
        // 
        // txtCliente
        // 
        txtCliente.Location = new Point(200, 65);
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(220, 27);
        txtCliente.TabIndex = 3;
        // 
        // txtMonto
        // 
        txtMonto.Location = new Point(200, 145);
        txtMonto.Name = "txtMonto";
        txtMonto.Size = new Size(220, 27);
        txtMonto.TabIndex = 7;
        // 
        // txtBase
        // 
        txtBase.Location = new Point(200, 195);
        txtBase.Name = "txtBase";
        txtBase.ReadOnly = true;
        txtBase.Size = new Size(220, 27);
        txtBase.TabIndex = 9;
        // 
        // txtIGV
        // 
        txtIGV.Location = new Point(200, 235);
        txtIGV.Name = "txtIGV";
        txtIGV.ReadOnly = true;
        txtIGV.Size = new Size(220, 27);
        txtIGV.TabIndex = 11;
        // 
        // txtTotal
        // 
        txtTotal.Location = new Point(200, 275);
        txtTotal.Name = "txtTotal";
        txtTotal.ReadOnly = true;
        txtTotal.Size = new Size(220, 27);
        txtTotal.TabIndex = 13;
        // 
        // cboMotivo
        // 
        cboMotivo.Items.AddRange(new object[] { "Anulación", "Devolución", "Descuento", "Corrección de monto" });
        cboMotivo.Location = new Point(200, 105);
        cboMotivo.Name = "cboMotivo";
        cboMotivo.Size = new Size(220, 28);
        cboMotivo.TabIndex = 5;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(30, 340);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(75, 31);
        btnCalcular.TabIndex = 14;
        btnCalcular.Text = "Calcular";
        btnCalcular.Click += btnCalcular_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(140, 340);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(75, 31);
        btnGuardar.TabIndex = 15;
        btnGuardar.Text = "Guardar";
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(250, 340);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(75, 31);
        btnLimpiar.TabIndex = 16;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnSalir
        // 
        btnSalir.Location = new Point(360, 340);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(75, 31);
        btnSalir.TabIndex = 17;
        btnSalir.Text = "Salir";
        btnSalir.Click += btnSalir_Click;
        // 
        // lblComprobante
        // 
        lblComprobante.AutoSize = true;
        lblComprobante.Location = new Point(30, 30);
        lblComprobante.Name = "lblComprobante";
        lblComprobante.Size = new Size(167, 20);
        lblComprobante.TabIndex = 0;
        lblComprobante.Text = "Comprobante afectado:";
        // 
        // lblCliente
        // 
        lblCliente.AutoSize = true;
        lblCliente.Location = new Point(30, 70);
        lblCliente.Name = "lblCliente";
        lblCliente.Size = new Size(58, 20);
        lblCliente.TabIndex = 2;
        lblCliente.Text = "Cliente:";
        // 
        // lblMotivo
        // 
        lblMotivo.AutoSize = true;
        lblMotivo.Location = new Point(30, 110);
        lblMotivo.Name = "lblMotivo";
        lblMotivo.Size = new Size(59, 20);
        lblMotivo.TabIndex = 4;
        lblMotivo.Text = "Motivo:";
        // 
        // lblMonto
        // 
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(30, 150);
        lblMonto.Name = "lblMonto";
        lblMonto.Size = new Size(91, 20);
        lblMonto.TabIndex = 6;
        lblMonto.Text = "Monto total:";
        // 
        // lblBase
        // 
        lblBase.AutoSize = true;
        lblBase.Location = new Point(30, 200);
        lblBase.Name = "lblBase";
        lblBase.Size = new Size(115, 20);
        lblBase.TabIndex = 8;
        lblBase.Text = "Base imponible:";
        // 
        // lblIGV
        // 
        lblIGV.AutoSize = true;
        lblIGV.Location = new Point(30, 240);
        lblIGV.Name = "lblIGV";
        lblIGV.Size = new Size(67, 20);
        lblIGV.TabIndex = 10;
        lblIGV.Text = "IGV 18%:";
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Location = new Point(30, 280);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(45, 20);
        lblTotal.TabIndex = 12;
        lblTotal.Text = "Total:";
        // 
        // FrmNotaCredito
        // 
        ClientSize = new Size(482, 453);
        Controls.Add(lblComprobante);
        Controls.Add(txtComprobante);
        Controls.Add(lblCliente);
        Controls.Add(txtCliente);
        Controls.Add(lblMotivo);
        Controls.Add(cboMotivo);
        Controls.Add(lblMonto);
        Controls.Add(txtMonto);
        Controls.Add(lblBase);
        Controls.Add(txtBase);
        Controls.Add(lblIGV);
        Controls.Add(txtIGV);
        Controls.Add(lblTotal);
        Controls.Add(txtTotal);
        Controls.Add(btnCalcular);
        Controls.Add(btnGuardar);
        Controls.Add(btnLimpiar);
        Controls.Add(btnSalir);
        Name = "FrmNotaCredito";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registro Nota de Crédito SUNAT";
        ResumeLayout(false);
        PerformLayout();
    }
    private Label lblComprobante;
    private Label lblCliente;
    private Label lblMotivo;
    private Label lblMonto;
    private Label lblBase;
    private Label lblIGV;
    private Label lblTotal;
}