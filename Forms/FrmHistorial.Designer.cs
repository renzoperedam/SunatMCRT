namespace SunatMCRT.Forms;

partial class FrmHistorial
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitulo;
    private Label lblTotalRegistros;
    private DataGridView dgvHistorial;
    private Button btnActualizar;
    private Button btnCerrar;
    private Label lblBuscarRuc;
    private TextBox txtBuscarRuc;
    private Button btnBuscar;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblTotalRegistros = new Label();
        dgvHistorial = new DataGridView();
        btnActualizar = new Button();
        btnCerrar = new Button();
        lblBuscarRuc = new Label();
        txtBuscarRuc = new TextBox();
        btnBuscar = new Button();
        panel2 = new Panel();
        panel3 = new Panel();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitulo.Location = new Point(23, 43);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(743, 47);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Historial de comprobantes procesados";
        // 
        // lblTotalRegistros
        // 
        lblTotalRegistros.Location = new Point(10, 491);
        lblTotalRegistros.Name = "lblTotalRegistros";
        lblTotalRegistros.Size = new Size(183, 33);
        lblTotalRegistros.TabIndex = 1;
        lblTotalRegistros.Text = "Total de registros: 0";
        // 
        // dgvHistorial
        // 
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AllowUserToDeleteRows = false;
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHistorial.Location = new Point(15, 153);
        dgvHistorial.Margin = new Padding(3, 4, 3, 4);
        dgvHistorial.MultiSelect = false;
        dgvHistorial.Name = "dgvHistorial";
        dgvHistorial.ReadOnly = true;
        dgvHistorial.RowHeadersWidth = 51;
        dgvHistorial.RowTemplate.Height = 25;
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHistorial.Size = new Size(943, 334);
        dgvHistorial.TabIndex = 2;
        dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(335, 513);
        btnActualizar.Margin = new Padding(3, 4, 3, 4);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(137, 47);
        btnActualizar.TabIndex = 3;
        btnActualizar.Text = "Actualizar";
        btnActualizar.Click += btnActualizar_Click;
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new Point(495, 513);
        btnCerrar.Margin = new Padding(3, 4, 3, 4);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(137, 47);
        btnCerrar.TabIndex = 4;
        btnCerrar.Text = "Cerrar";
        btnCerrar.Click += btnCerrar_Click;
        // 
        // lblBuscarRuc
        // 
        lblBuscarRuc.AutoSize = true;
        lblBuscarRuc.Location = new Point(12, 15);
        lblBuscarRuc.Name = "lblBuscarRuc";
        lblBuscarRuc.Size = new Size(72, 15);
        lblBuscarRuc.TabIndex = 0;
        lblBuscarRuc.Text = "Buscar RUC";
        // 
        // txtBuscarRuc
        // 
        txtBuscarRuc.Location = new Point(90, 12);
        txtBuscarRuc.Name = "txtBuscarRuc";
        txtBuscarRuc.Size = new Size(220, 23);
        txtBuscarRuc.TabIndex = 1;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(320, 11);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(90, 25);
        btnBuscar.TabIndex = 2;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.WhiteSmoke;
        panel2.Controls.Add(pictureBox1);
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(lblTitulo);
        panel2.Location = new Point(-13, -7);
        panel2.Name = "panel2";
        panel2.Size = new Size(1012, 123);
        panel2.TabIndex = 18;
        // 
        // panel3
        // 
        panel3.BackColor = Color.SteelBlue;
        panel3.Location = new Point(13, 2);
        panel3.Name = "panel3";
        panel3.Size = new Size(988, 10);
        panel3.TabIndex = 20;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logo_sunat;
        pictureBox1.Location = new Point(865, 18);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(106, 97);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 20;
        pictureBox1.TabStop = false;
        // 
        // FrmHistorial
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(974, 588);
        Controls.Add(panel2);
        Controls.Add(lblTotalRegistros);
        Controls.Add(dgvHistorial);
        Controls.Add(btnActualizar);
        Controls.Add(btnCerrar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscarRuc);
        Controls.Add(lblBuscarRuc);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmHistorial";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Historial de Comprobantes";
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        // Funcionalidad pendiente para siguiente commit
    }

    private Panel panel2;
    private Panel panel3;
    private PictureBox pictureBox1;
}

