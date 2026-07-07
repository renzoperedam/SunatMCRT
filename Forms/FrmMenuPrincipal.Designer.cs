namespace SunatMCRT.Forms;

partial class FrmMenuPrincipal
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private Button btnFactura;
    private Button btnRecibo;
    private Button btnHistorial;
    private Button btnSalir;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        btnFactura = new Button();
        btnRecibo = new Button();
        btnHistorial = new Button();
        btnSalir = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        pictureBox1 = new PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(108, 21);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(594, 53);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "SISTEMA TRIBUTARIO MCRT";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.Location = new Point(108, 79);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(594, 40);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Gestión y cálculo de comprobantes tributarios";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnFactura
        // 
        btnFactura.BackColor = Color.DarkSeaGreen;
        btnFactura.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnFactura.Location = new Point(87, 212);
        btnFactura.Margin = new Padding(3, 4, 3, 4);
        btnFactura.Name = "btnFactura";
        btnFactura.Size = new Size(282, 60);
        btnFactura.TabIndex = 2;
        btnFactura.Text = "Registrar Factura";
        btnFactura.UseVisualStyleBackColor = false;
        btnFactura.Click += btnFactura_Click;
        // 
        // btnRecibo
        // 
        btnRecibo.BackColor = Color.Khaki;
        btnRecibo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnRecibo.Location = new Point(399, 212);
        btnRecibo.Margin = new Padding(3, 4, 3, 4);
        btnRecibo.Name = "btnRecibo";
        btnRecibo.Size = new Size(282, 60);
        btnRecibo.TabIndex = 3;
        btnRecibo.Text = "Registrar Recibo por Honorarios";
        btnRecibo.UseVisualStyleBackColor = false;
        btnRecibo.Click += btnRecibo_Click;
        // 
        // btnHistorial
        // 
        btnHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnHistorial.Location = new Point(244, 297);
        btnHistorial.Margin = new Padding(3, 4, 3, 4);
        btnHistorial.Name = "btnHistorial";
        btnHistorial.Size = new Size(282, 60);
        btnHistorial.TabIndex = 4;
        btnHistorial.Text = "Ver Historial";
        btnHistorial.UseVisualStyleBackColor = true;
        btnHistorial.Click += btnHistorial_Click;
        // 
        // btnSalir
        // 
        btnSalir.Location = new Point(625, 433);
        btnSalir.Margin = new Padding(3, 4, 3, 4);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(126, 47);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.WhiteSmoke;
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(lblSubtitulo);
        panel1.Controls.Add(lblTitulo);
        panel1.Location = new Point(-21, 1);
        panel1.Name = "panel1";
        panel1.Size = new Size(804, 135);
        panel1.TabIndex = 15;
        // 
        // panel2
        // 
        panel2.BackColor = Color.SteelBlue;
        panel2.Location = new Point(14, -5);
        panel2.Name = "panel2";
        panel2.Size = new Size(780, 13);
        panel2.TabIndex = 16;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logo_sunat;
        pictureBox1.Location = new Point(666, 21);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(106, 97);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 20;
        pictureBox1.TabStop = false;
        // 
        // FrmMenuPrincipal
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(763, 493);
        Controls.Add(panel1);
        Controls.Add(btnFactura);
        Controls.Add(btnRecibo);
        Controls.Add(btnHistorial);
        Controls.Add(btnSalir);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmMenuPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Menú Principal - Sistema Tributario MCRT";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }
    private Panel panel1;
    private Panel panel2;
    private PictureBox pictureBox1;
}
