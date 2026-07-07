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
        this.txtComprobante = new TextBox();
        this.txtCliente = new TextBox();
        this.txtMonto = new TextBox();
        this.txtBase = new TextBox();
        this.txtIGV = new TextBox();
        this.txtTotal = new TextBox();

        this.cboMotivo = new ComboBox();

        this.btnCalcular = new Button();
        this.btnGuardar = new Button();
        this.btnLimpiar = new Button();
        this.btnSalir = new Button();


        this.SuspendLayout();


        // FORMULARIO
        this.Text = "Registro Nota de Crédito SUNAT";
        this.Size = new Size(500, 500);
        this.StartPosition = FormStartPosition.CenterScreen;


        // LABEL COMPROBANTE
        Label lblComprobante = new Label();
        lblComprobante.Text = "Comprobante afectado:";
        lblComprobante.Location = new Point(30, 30);
        lblComprobante.AutoSize = true;


        // TEXTBOX COMPROBANTE
        this.txtComprobante.Location = new Point(200, 25);
        this.txtComprobante.Width = 220;


        // LABEL CLIENTE
        Label lblCliente = new Label();
        lblCliente.Text = "Cliente:";
        lblCliente.Location = new Point(30, 70);
        lblCliente.AutoSize = true;


        this.txtCliente.Location = new Point(200, 65);
        this.txtCliente.Width = 220;



        // LABEL MOTIVO
        Label lblMotivo = new Label();
        lblMotivo.Text = "Motivo:";
        lblMotivo.Location = new Point(30, 110);
        lblMotivo.AutoSize = true;


        this.cboMotivo.Location = new Point(200, 105);
        this.cboMotivo.Width = 220;

        this.cboMotivo.Items.AddRange(new object[]
        {
            "Anulación",
            "Devolución",
            "Descuento",
            "Corrección de monto"
        });



        // LABEL MONTO
        Label lblMonto = new Label();
        lblMonto.Text = "Monto total:";
        lblMonto.Location = new Point(30, 150);
        lblMonto.AutoSize = true;


        this.txtMonto.Location = new Point(200, 145);
        this.txtMonto.Width = 220;



        // LABEL BASE
        Label lblBase = new Label();
        lblBase.Text = "Base imponible:";
        lblBase.Location = new Point(30, 200);
        lblBase.AutoSize = true;


        this.txtBase.Location = new Point(200, 195);
        this.txtBase.Width = 220;
        this.txtBase.ReadOnly = true;



        // LABEL IGV
        Label lblIGV = new Label();
        lblIGV.Text = "IGV 18%:";
        lblIGV.Location = new Point(30, 240);
        lblIGV.AutoSize = true;


        this.txtIGV.Location = new Point(200, 235);
        this.txtIGV.Width = 220;
        this.txtIGV.ReadOnly = true;



        // LABEL TOTAL
        Label lblTotal = new Label();
        lblTotal.Text = "Total:";
        lblTotal.Location = new Point(30, 280);
        lblTotal.AutoSize = true;


        this.txtTotal.Location = new Point(200, 275);
        this.txtTotal.Width = 220;
        this.txtTotal.ReadOnly = true;



        // BOTON CALCULAR
        this.btnCalcular.Text = "Calcular";
        this.btnCalcular.Location = new Point(30, 340);
        this.btnCalcular.Click += btnCalcular_Click;



        // BOTON GUARDAR
        this.btnGuardar.Text = "Guardar";
        this.btnGuardar.Location = new Point(140, 340);
        this.btnGuardar.Click += btnGuardar_Click;



        // BOTON LIMPIAR
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.Location = new Point(250, 340);
        this.btnLimpiar.Click += btnLimpiar_Click;



        // BOTON SALIR
        this.btnSalir.Text = "Salir";
        this.btnSalir.Location = new Point(360, 340);
        this.btnSalir.Click += btnSalir_Click;



        // AGREGAR CONTROLES
        this.Controls.Add(lblComprobante);
        this.Controls.Add(txtComprobante);

        this.Controls.Add(lblCliente);
        this.Controls.Add(txtCliente);

        this.Controls.Add(lblMotivo);
        this.Controls.Add(cboMotivo);

        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);

        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);

        this.Controls.Add(lblIGV);
        this.Controls.Add(txtIGV);

        this.Controls.Add(lblTotal);
        this.Controls.Add(txtTotal);

        this.Controls.Add(btnCalcular);
        this.Controls.Add(btnGuardar);
        this.Controls.Add(btnLimpiar);
        this.Controls.Add(btnSalir);



        this.ResumeLayout(false);
    }
}