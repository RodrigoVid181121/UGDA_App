﻿namespace UGDA_App
{
    partial class users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            tabControl1 = new TabControl();
            tbSeries = new TabPage();
            panel1 = new Panel();
            txtBuscar = new TextBox();
            cmbfiltro = new ComboBox();
            btneliminar = new Button();
            pictureBox1 = new PictureBox();
            dgvbuscar = new DataGridView();
            tbSubs = new TabPage();
            pcView2 = new PictureBox();
            pcView = new PictureBox();
            label7 = new Label();
            txtConf = new TextBox();
            label6 = new Label();
            txtcontra = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtcarnet = new TextBox();
            txtcorreo = new TextBox();
            txtapellido = new TextBox();
            txtnom = new TextBox();
            btnAñadir = new Button();
            btnedit = new Button();
            cbcargo = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tbSeries.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).BeginInit();
            tbSubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tbSeries);
            tabControl1.Controls.Add(tbSubs);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(200, 50);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 506);
            tabControl1.TabIndex = 0;
            // 
            // tbSeries
            // 
            tbSeries.BackColor = Color.FromArgb(0, 27, 89);
            tbSeries.Controls.Add(panel1);
            tbSeries.Controls.Add(dgvbuscar);
            tbSeries.Location = new Point(4, 54);
            tbSeries.Margin = new Padding(2, 1, 2, 1);
            tbSeries.Name = "tbSeries";
            tbSeries.Padding = new Padding(2, 1, 2, 1);
            tbSeries.Size = new Size(786, 448);
            tbSeries.TabIndex = 0;
            tbSeries.Text = "Buscar";
            tbSeries.Click += tbBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cmbfiltro);
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(56, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 90);
            panel1.TabIndex = 23;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.ButtonFace;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(86, 31);
            txtBuscar.Margin = new Padding(2, 1, 2, 1);
            txtBuscar.MaxLength = 200;
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Usuario";
            txtBuscar.Size = new Size(312, 25);
            txtBuscar.TabIndex = 26;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // cmbfiltro
            // 
            cmbfiltro.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbfiltro.FormattingEnabled = true;
            cmbfiltro.Items.AddRange(new object[] { "Carnet", "Nombre" });
            cmbfiltro.Location = new Point(412, 31);
            cmbfiltro.Name = "cmbfiltro";
            cmbfiltro.Size = new Size(151, 31);
            cmbfiltro.TabIndex = 25;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(0, 0, 64);
            btneliminar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.WhiteSmoke;
            btneliminar.Location = new Point(579, 27);
            btneliminar.Margin = new Padding(2, 1, 2, 1);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(83, 33);
            btneliminar.TabIndex = 24;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // dgvbuscar
            // 
            dgvbuscar.AllowUserToAddRows = false;
            dgvbuscar.AllowUserToDeleteRows = false;
            dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvbuscar.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvbuscar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvbuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbuscar.GridColor = Color.Peru;
            dgvbuscar.Location = new Point(56, 144);
            dgvbuscar.Margin = new Padding(2, 1, 2, 1);
            dgvbuscar.Name = "dgvbuscar";
            dgvbuscar.ReadOnly = true;
            dgvbuscar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvbuscar.RowTemplate.Height = 41;
            dgvbuscar.Size = new Size(678, 263);
            dgvbuscar.TabIndex = 17;
            dgvbuscar.CellClick += dgvbuscar_CellClick;
            // 
            // tbSubs
            // 
            tbSubs.BackColor = Color.FromArgb(0, 27, 89);
            tbSubs.Controls.Add(pcView2);
            tbSubs.Controls.Add(pcView);
            tbSubs.Controls.Add(label7);
            tbSubs.Controls.Add(txtConf);
            tbSubs.Controls.Add(label6);
            tbSubs.Controls.Add(txtcontra);
            tbSubs.Controls.Add(label5);
            tbSubs.Controls.Add(label4);
            tbSubs.Controls.Add(label3);
            tbSubs.Controls.Add(label2);
            tbSubs.Controls.Add(label1);
            tbSubs.Controls.Add(pictureBox2);
            tbSubs.Controls.Add(txtcarnet);
            tbSubs.Controls.Add(txtcorreo);
            tbSubs.Controls.Add(txtapellido);
            tbSubs.Controls.Add(txtnom);
            tbSubs.Controls.Add(btnAñadir);
            tbSubs.Controls.Add(btnedit);
            tbSubs.Controls.Add(cbcargo);
            tbSubs.ForeColor = SystemColors.ControlDarkDark;
            tbSubs.Location = new Point(4, 54);
            tbSubs.Margin = new Padding(2, 1, 2, 1);
            tbSubs.Name = "tbSubs";
            tbSubs.Padding = new Padding(2, 1, 2, 1);
            tbSubs.Size = new Size(786, 448);
            tbSubs.TabIndex = 1;
            tbSubs.Text = "Agregar";
            tbSubs.Click += tbSubs_Click;
            // 
            // pcView2
            // 
            pcView2.Cursor = Cursors.Hand;
            pcView2.Image = (Image)resources.GetObject("pcView2.Image");
            pcView2.Location = new Point(753, 379);
            pcView2.Margin = new Padding(2, 1, 2, 1);
            pcView2.Name = "pcView2";
            pcView2.Size = new Size(29, 28);
            pcView2.SizeMode = PictureBoxSizeMode.Zoom;
            pcView2.TabIndex = 37;
            pcView2.TabStop = false;
            pcView2.Click += pcView2_Click;
            // 
            // pcView
            // 
            pcView.Cursor = Cursors.Hand;
            pcView.Image = (Image)resources.GetObject("pcView.Image");
            pcView.Location = new Point(753, 324);
            pcView.Margin = new Padding(2, 1, 2, 1);
            pcView.Name = "pcView";
            pcView.Size = new Size(29, 28);
            pcView.SizeMode = PictureBoxSizeMode.Zoom;
            pcView.TabIndex = 36;
            pcView.TabStop = false;
            pcView.Click += pcView_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(316, 382);
            label7.Name = "label7";
            label7.Size = new Size(206, 25);
            label7.TabIndex = 35;
            label7.Text = "Confirmar Contraseña:";
            // 
            // txtConf
            // 
            txtConf.BackColor = Color.WhiteSmoke;
            txtConf.BorderStyle = BorderStyle.None;
            txtConf.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConf.Location = new Point(532, 382);
            txtConf.Margin = new Padding(2, 1, 2, 1);
            txtConf.MaxLength = 20;
            txtConf.Name = "txtConf";
            txtConf.PasswordChar = '*';
            txtConf.Size = new Size(217, 25);
            txtConf.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(413, 327);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 33;
            label6.Text = "Contraseña:";
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.WhiteSmoke;
            txtcontra.BorderStyle = BorderStyle.None;
            txtcontra.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontra.Location = new Point(532, 327);
            txtcontra.Margin = new Padding(2, 1, 2, 1);
            txtcontra.MaxLength = 20;
            txtcontra.Name = "txtcontra";
            txtcontra.PasswordChar = '*';
            txtcontra.Size = new Size(217, 25);
            txtcontra.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(459, 150);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 31;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(452, 210);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 30;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(453, 270);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 29;
            label3.Text = "Carnet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(439, 94);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 28;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(439, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 27;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // txtcarnet
            // 
            txtcarnet.BackColor = Color.WhiteSmoke;
            txtcarnet.BorderStyle = BorderStyle.None;
            txtcarnet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtcarnet.Location = new Point(532, 270);
            txtcarnet.Margin = new Padding(2, 1, 2, 1);
            txtcarnet.MaxLength = 6;
            txtcarnet.Name = "txtcarnet";
            txtcarnet.ReadOnly = true;
            txtcarnet.Size = new Size(217, 25);
            txtcarnet.TabIndex = 25;
            // 
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.WhiteSmoke;
            txtcorreo.BorderStyle = BorderStyle.None;
            txtcorreo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtcorreo.Location = new Point(532, 210);
            txtcorreo.Margin = new Padding(2, 1, 2, 1);
            txtcorreo.MaxLength = 200;
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(217, 25);
            txtcorreo.TabIndex = 24;
            txtcorreo.TextChanged += txtcorreo_TextChanged;
            txtcorreo.Leave += txtcorreo_Leave;
            // 
            // txtapellido
            // 
            txtapellido.BackColor = Color.WhiteSmoke;
            txtapellido.BorderStyle = BorderStyle.None;
            txtapellido.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtapellido.Location = new Point(532, 94);
            txtapellido.Margin = new Padding(2, 1, 2, 1);
            txtapellido.MaxLength = 50;
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(217, 25);
            txtapellido.TabIndex = 23;
            txtapellido.Leave += txtapellido_Leave;
            // 
            // txtnom
            // 
            txtnom.BackColor = Color.WhiteSmoke;
            txtnom.BorderStyle = BorderStyle.None;
            txtnom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtnom.Location = new Point(532, 37);
            txtnom.Margin = new Padding(2, 1, 2, 1);
            txtnom.MaxLength = 50;
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(217, 25);
            txtnom.TabIndex = 22;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.FromArgb(0, 0, 64);
            btnAñadir.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadir.ForeColor = Color.WhiteSmoke;
            btnAñadir.Location = new Point(149, 382);
            btnAñadir.Margin = new Padding(2, 1, 2, 1);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(100, 33);
            btnAñadir.TabIndex = 21;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(0, 0, 64);
            btnedit.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnedit.ForeColor = Color.WhiteSmoke;
            btnedit.Location = new Point(27, 382);
            btnedit.Margin = new Padding(2, 1, 2, 1);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(100, 33);
            btnedit.TabIndex = 20;
            btnedit.Text = "Modificar";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // cbcargo
            // 
            cbcargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbcargo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbcargo.BackColor = Color.WhiteSmoke;
            cbcargo.FlatStyle = FlatStyle.Flat;
            cbcargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbcargo.FormattingEnabled = true;
            cbcargo.Location = new Point(532, 150);
            cbcargo.Margin = new Padding(2, 1, 2, 1);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(217, 29);
            cbcargo.TabIndex = 18;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(794, 506);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += users_Load;
            tabControl1.ResumeLayout(false);
            tbSeries.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).EndInit();
            tbSubs.ResumeLayout(false);
            tbSubs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbSeries;
        private TabPage tbSubs;
        private ErrorProvider errorProvider1;
        private DataGridView dgvbuscar;
        private TextBox txtnom;
        private Button btnAñadir;
        private Button btnedit;
        private ComboBox cbcargo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtcarnet;
        private TextBox txtcorreo;
        private TextBox txtapellido;
        private Label label7;
        private TextBox txtConf;
        private Label label6;
        private TextBox txtcontra;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pcView2;
        private PictureBox pcView;
        private Button btneliminar;
        private ComboBox cmbfiltro;
        private TextBox txtBuscar;
    }
}