namespace SunatMCRT.Forms;

partial class FrmReciboHonorario
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitulo;
    private Label lblNota;
    private Label lblRuc;
    private Label lblRazonSocial;
    private Label lblMontoBase;
    private TextBox txtRuc;
    private TextBox txtRazonSocial;
    private TextBox txtMontoBase;
    private Button btnProcesar;
    private Button btnLimpiar;
    private Button btnCerrar;
    private Label lblRetencion;
    private Label lblNeto;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblNota = new Label();
        lblRuc = new Label();
        lblRazonSocial = new Label();
        lblMontoBase = new Label();
        txtRuc = new TextBox();
        txtRazonSocial = new TextBox();
        txtMontoBase = new TextBox();
        btnProcesar = new Button();
        btnLimpiar = new Button();
        btnCerrar = new Button();
        lblRetencion = new Label();
        lblNeto = new Label();
        panel1 = new Panel();
        panel2 = new Panel();
        panel3 = new Panel();
        pictureBox1 = new PictureBox();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitulo.Location = new Point(40, 27);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(583, 47);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registro de Recibo por Honorarios";
        // 
        // lblNota
        // 
        lblNota.Location = new Point(62, 77);
        lblNota.Name = "lblNota";
        lblNota.Size = new Size(526, 33);
        lblNota.TabIndex = 1;
        lblNota.Text = "Si el monto supera S/ 1,500.00, se aplica retención del 8%.";
        // 
        // lblRuc
        // 
        lblRuc.Location = new Point(153, 154);
        lblRuc.Name = "lblRuc";
        lblRuc.Size = new Size(160, 33);
        lblRuc.TabIndex = 2;
        lblRuc.Text = "RUC del profesional:";
        // 
        // lblRazonSocial
        // 
        lblRazonSocial.Location = new Point(153, 214);
        lblRazonSocial.Name = "lblRazonSocial";
        lblRazonSocial.Size = new Size(166, 33);
        lblRazonSocial.TabIndex = 4;
        lblRazonSocial.Text = "Nombre/Razón social:";
        // 
        // lblMontoBase
        // 
        lblMontoBase.Location = new Point(153, 274);
        lblMontoBase.Name = "lblMontoBase";
        lblMontoBase.Size = new Size(160, 33);
        lblMontoBase.TabIndex = 6;
        lblMontoBase.Text = "Monto del recibo:";
        // 
        // txtRuc
        // 
        txtRuc.Location = new Point(331, 150);
        txtRuc.Margin = new Padding(3, 4, 3, 4);
        txtRuc.Name = "txtRuc";
        txtRuc.Size = new Size(297, 27);
        txtRuc.TabIndex = 3;
        // 
        // txtRazonSocial
        // 
        txtRazonSocial.Location = new Point(331, 210);
        txtRazonSocial.Margin = new Padding(3, 4, 3, 4);
        txtRazonSocial.Name = "txtRazonSocial";
        txtRazonSocial.Size = new Size(297, 27);
        txtRazonSocial.TabIndex = 5;
        // 
        // txtMontoBase
        // 
        txtMontoBase.Location = new Point(331, 270);
        txtMontoBase.Margin = new Padding(3, 4, 3, 4);
        txtMontoBase.Name = "txtMontoBase";
        txtMontoBase.Size = new Size(297, 27);
        txtMontoBase.TabIndex = 7;
        // 
        // btnProcesar
        // 
        btnProcesar.Location = new Point(188, 326);
        btnProcesar.Margin = new Padding(3, 4, 3, 4);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(160, 47);
        btnProcesar.TabIndex = 8;
        btnProcesar.Text = "Calcular y guardar";
        btnProcesar.Click += btnProcesar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(365, 326);
        btnLimpiar.Margin = new Padding(3, 4, 3, 4);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(114, 47);
        btnLimpiar.TabIndex = 9;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new Point(496, 326);
        btnCerrar.Margin = new Padding(3, 4, 3, 4);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(114, 47);
        btnCerrar.TabIndex = 10;
        btnCerrar.Text = "Cerrar";
        btnCerrar.Click += btnCerrar_Click;
        // 
        // lblRetencion
        // 
        lblRetencion.BackColor = Color.Ivory;
        lblRetencion.BorderStyle = BorderStyle.FixedSingle;
        lblRetencion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblRetencion.Location = new Point(188, 406);
        lblRetencion.Name = "lblRetencion";
        lblRetencion.Size = new Size(423, 46);
        lblRetencion.TabIndex = 11;
        lblRetencion.Text = "Retención 4ta categoría: S/ 0.00";
        lblRetencion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblNeto
        // 
        lblNeto.BackColor = SystemColors.GradientActiveCaption;
        lblNeto.BorderStyle = BorderStyle.FixedSingle;
        lblNeto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblNeto.Location = new Point(188, 466);
        lblNeto.Name = "lblNeto";
        lblNeto.Size = new Size(423, 46);
        lblNeto.TabIndex = 12;
        lblNeto.Text = "Neto a recibir: S/ 0.00";
        lblNeto.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel1
        // 
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 100);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = Color.WhiteSmoke;
        panel2.Controls.Add(pictureBox1);
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(lblTitulo);
        panel2.Controls.Add(lblNota);
        panel2.Location = new Point(-12, -5);
        panel2.Name = "panel2";
        panel2.Size = new Size(823, 127);
        panel2.TabIndex = 14;
        // 
        // panel3
        // 
        panel3.BackColor = Color.SteelBlue;
        panel3.Location = new Point(12, 2);
        panel3.Name = "panel3";
        panel3.Size = new Size(832, 10);
        panel3.TabIndex = 19;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logo_sunat;
        pictureBox1.Location = new Point(695, 18);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(106, 97);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 20;
        pictureBox1.TabStop = false;
        // 
        // FrmReciboHonorario
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(801, 542);
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
        Controls.Add(lblRetencion);
        Controls.Add(lblNeto);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmReciboHonorario";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registrar Recibo por Honorarios";
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private PictureBox pictureBox1;
}
