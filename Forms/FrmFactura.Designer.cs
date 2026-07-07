namespace SunatMCRT.Forms;

partial class FrmFactura
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitulo;
    private Label lblRuc;
    private Label lblRazonSocial;
    private Label lblMontoBase;
    private TextBox txtRuc;
    private TextBox txtRazonSocial;
    private TextBox txtMontoBase;
    private Button btnProcesar;
    private Button btnLimpiar;
    private Button btnCerrar;
    private Label lblIgv;
    private Label lblTotal;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblRuc = new Label();
        lblRazonSocial = new Label();
        lblMontoBase = new Label();
        txtRuc = new TextBox();
        txtRazonSocial = new TextBox();
        txtMontoBase = new TextBox();
        btnProcesar = new Button();
        btnLimpiar = new Button();
        btnCerrar = new Button();
        lblIgv = new Label();
        lblTotal = new Label();
        panel2 = new Panel();
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitulo.Location = new Point(21, 62);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(549, 47);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registro de Factura y cálculo de IGV";
        // 
        // lblRuc
        // 
        lblRuc.Location = new Point(38, 167);
        lblRuc.Name = "lblRuc";
        lblRuc.Size = new Size(137, 33);
        lblRuc.TabIndex = 1;
        lblRuc.Text = "RUC del emisor:";
        // 
        // lblRazonSocial
        // 
        lblRazonSocial.Location = new Point(38, 227);
        lblRazonSocial.Name = "lblRazonSocial";
        lblRazonSocial.Size = new Size(137, 33);
        lblRazonSocial.TabIndex = 3;
        lblRazonSocial.Text = "Razón social:";
        // 
        // lblMontoBase
        // 
        lblMontoBase.Location = new Point(38, 287);
        lblMontoBase.Name = "lblMontoBase";
        lblMontoBase.Size = new Size(137, 33);
        lblMontoBase.TabIndex = 5;
        lblMontoBase.Text = "Monto base:";
        // 
        // txtRuc
        // 
        txtRuc.Location = new Point(193, 163);
        txtRuc.Margin = new Padding(3, 4, 3, 4);
        txtRuc.Name = "txtRuc";
        txtRuc.Size = new Size(297, 27);
        txtRuc.TabIndex = 2;
        // 
        // txtRazonSocial
        // 
        txtRazonSocial.Location = new Point(193, 223);
        txtRazonSocial.Margin = new Padding(3, 4, 3, 4);
        txtRazonSocial.Name = "txtRazonSocial";
        txtRazonSocial.Size = new Size(297, 27);
        txtRazonSocial.TabIndex = 4;
        // 
        // txtMontoBase
        // 
        txtMontoBase.Location = new Point(193, 283);
        txtMontoBase.Margin = new Padding(3, 4, 3, 4);
        txtMontoBase.Name = "txtMontoBase";
        txtMontoBase.Size = new Size(297, 27);
        txtMontoBase.TabIndex = 6;
        // 
        // btnProcesar
        // 
        btnProcesar.Location = new Point(67, 331);
        btnProcesar.Margin = new Padding(3, 4, 3, 4);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(160, 47);
        btnProcesar.TabIndex = 7;
        btnProcesar.Text = "Calcular y guardar";
        btnProcesar.Click += btnProcesar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(244, 331);
        btnLimpiar.Margin = new Padding(3, 4, 3, 4);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(114, 47);
        btnLimpiar.TabIndex = 8;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new Point(376, 331);
        btnCerrar.Margin = new Padding(3, 4, 3, 4);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(114, 47);
        btnCerrar.TabIndex = 9;
        btnCerrar.Text = "Cerrar";
        btnCerrar.Click += btnCerrar_Click;
        // 
        // lblIgv
        // 
        lblIgv.BorderStyle = BorderStyle.FixedSingle;
        lblIgv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblIgv.Location = new Point(67, 390);
        lblIgv.Name = "lblIgv";
        lblIgv.Size = new Size(423, 46);
        lblIgv.TabIndex = 10;
        lblIgv.Text = "IGV: S/ 0.00";
        lblIgv.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTotal
        // 
        lblTotal.BorderStyle = BorderStyle.FixedSingle;
        lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotal.Location = new Point(67, 450);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(423, 46);
        lblTotal.TabIndex = 11;
        lblTotal.Text = "Total a pagar: S/ 0.00";
        lblTotal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel2
        // 
        panel2.BackColor = Color.WhiteSmoke;
        panel2.Controls.Add(pictureBox1);
        panel2.Controls.Add(panel1);
        panel2.Controls.Add(lblTitulo);
        panel2.Location = new Point(-9, -1);
        panel2.Name = "panel2";
        panel2.Size = new Size(564, 144);
        panel2.TabIndex = 17;
        // 
        // panel1
        // 
        panel1.BackColor = Color.SteelBlue;
        panel1.Location = new Point(3, -4);
        panel1.Name = "panel1";
        panel1.Size = new Size(780, 13);
        panel1.TabIndex = 18;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logo_sunat;
        pictureBox1.Location = new Point(421, 25);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(106, 97);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 19;
        pictureBox1.TabStop = false;
        // 
        // FrmFactura
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(530, 521);
        Controls.Add(panel2);
        Controls.Add(lblRuc);
        Controls.Add(txtRuc);
        Controls.Add(lblRazonSocial);
        Controls.Add(txtRazonSocial);
        Controls.Add(lblMontoBase);
        Controls.Add(txtMontoBase);
        Controls.Add(btnProcesar);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCerrar);
        Controls.Add(lblIgv);
        Controls.Add(lblTotal);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmFactura";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registrar Factura";
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();

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

    private Panel panel2;
    private Panel panel1;
    private PictureBox pictureBox1;
}
