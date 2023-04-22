namespace UGDA_App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSeries = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.tbSubs = new System.Windows.Forms.TabPage();
            this.pcView2 = new System.Windows.Forms.PictureBox();
            this.pcView = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbSeries.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.tbSubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbSeries);
            this.tabControl1.Controls.Add(this.tbSubs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tbSeries
            // 
            this.tbSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tbSeries.Controls.Add(this.panel1);
            this.tbSeries.Controls.Add(this.dgvbuscar);
            this.tbSeries.Location = new System.Drawing.Point(4, 24);
            this.tbSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Size = new System.Drawing.Size(786, 478);
            this.tbSeries.TabIndex = 0;
            this.tbSeries.Text = "Buscar";
            this.tbSeries.Click += new System.EventHandler(this.tbBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.cmbfiltro);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(56, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 90);
            this.panel1.TabIndex = 23;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.Location = new System.Drawing.Point(86, 31);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscar.MaxLength = 200;
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar Usuario";
            this.txtBuscar.Size = new System.Drawing.Size(312, 25);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Items.AddRange(new object[] {
            "Código",
            "Nombre"});
            this.cmbfiltro.Location = new System.Drawing.Point(412, 31);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(151, 23);
            this.cmbfiltro.TabIndex = 25;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminar.Location = new System.Drawing.Point(579, 27);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(83, 33);
            this.btneliminar.TabIndex = 24;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.AllowUserToAddRows = false;
            this.dgvbuscar.AllowUserToDeleteRows = false;
            this.dgvbuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvbuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvbuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.GridColor = System.Drawing.Color.Peru;
            this.dgvbuscar.Location = new System.Drawing.Point(56, 144);
            this.dgvbuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.ReadOnly = true;
            this.dgvbuscar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvbuscar.RowTemplate.Height = 41;
            this.dgvbuscar.Size = new System.Drawing.Size(678, 263);
            this.dgvbuscar.TabIndex = 17;
            this.dgvbuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuscar_CellClick);
            // 
            // tbSubs
            // 
            this.tbSubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tbSubs.Controls.Add(this.pcView2);
            this.tbSubs.Controls.Add(this.pcView);
            this.tbSubs.Controls.Add(this.label7);
            this.tbSubs.Controls.Add(this.txtConf);
            this.tbSubs.Controls.Add(this.label6);
            this.tbSubs.Controls.Add(this.txtcontra);
            this.tbSubs.Controls.Add(this.label5);
            this.tbSubs.Controls.Add(this.label4);
            this.tbSubs.Controls.Add(this.label3);
            this.tbSubs.Controls.Add(this.label2);
            this.tbSubs.Controls.Add(this.label1);
            this.tbSubs.Controls.Add(this.pictureBox2);
            this.tbSubs.Controls.Add(this.txtcarnet);
            this.tbSubs.Controls.Add(this.txtcorreo);
            this.tbSubs.Controls.Add(this.txtapellido);
            this.tbSubs.Controls.Add(this.txtnom);
            this.tbSubs.Controls.Add(this.btnAñadir);
            this.tbSubs.Controls.Add(this.btnedit);
            this.tbSubs.Controls.Add(this.cbcargo);
            this.tbSubs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSubs.Location = new System.Drawing.Point(4, 24);
            this.tbSubs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubs.Name = "tbSubs";
            this.tbSubs.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubs.Size = new System.Drawing.Size(786, 478);
            this.tbSubs.TabIndex = 1;
            this.tbSubs.Text = "Agregar";
            this.tbSubs.Click += new System.EventHandler(this.tbSubs_Click);
            // 
            // pcView2
            // 
            this.pcView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcView2.Image = ((System.Drawing.Image)(resources.GetObject("pcView2.Image")));
            this.pcView2.Location = new System.Drawing.Point(753, 379);
            this.pcView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pcView2.Name = "pcView2";
            this.pcView2.Size = new System.Drawing.Size(29, 28);
            this.pcView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcView2.TabIndex = 37;
            this.pcView2.TabStop = false;
            this.pcView2.Click += new System.EventHandler(this.pcView2_Click);
            // 
            // pcView
            // 
            this.pcView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcView.Image = ((System.Drawing.Image)(resources.GetObject("pcView.Image")));
            this.pcView.Location = new System.Drawing.Point(753, 324);
            this.pcView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pcView.Name = "pcView";
            this.pcView.Size = new System.Drawing.Size(29, 28);
            this.pcView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcView.TabIndex = 36;
            this.pcView.TabStop = false;
            this.pcView.Click += new System.EventHandler(this.pcView_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(321, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Confirmar Contraseña:";
            // 
            // txtConf
            // 
            this.txtConf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConf.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConf.Location = new System.Drawing.Point(532, 382);
            this.txtConf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtConf.MaxLength = 20;
            this.txtConf.Name = "txtConf";
            this.txtConf.PasswordChar = '*';
            this.txtConf.Size = new System.Drawing.Size(217, 25);
            this.txtConf.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(413, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contraseña:";
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontra.Location = new System.Drawing.Point(532, 327);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtcontra.MaxLength = 20;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(217, 25);
            this.txtcontra.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(459, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(452, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(453, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(439, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(439, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txtcarnet
            // 
            this.txtcarnet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarnet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcarnet.Location = new System.Drawing.Point(532, 270);
            this.txtcarnet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtcarnet.MaxLength = 6;
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.ReadOnly = true;
            this.txtcarnet.Size = new System.Drawing.Size(217, 25);
            this.txtcarnet.TabIndex = 25;
            this.txtcarnet.Leave += new System.EventHandler(this.txtcarnet_Leave_1);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcorreo.Location = new System.Drawing.Point(532, 210);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtcorreo.MaxLength = 200;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(217, 25);
            this.txtcorreo.TabIndex = 24;
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtapellido.Location = new System.Drawing.Point(532, 94);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtapellido.MaxLength = 50;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(217, 25);
            this.txtapellido.TabIndex = 23;
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(532, 37);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtnom.MaxLength = 50;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(217, 25);
            this.txtnom.TabIndex = 22;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAñadir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAñadir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAñadir.Location = new System.Drawing.Point(149, 382);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 33);
            this.btnAñadir.TabIndex = 21;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnedit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnedit.Location = new System.Drawing.Point(27, 382);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 33);
            this.btnedit.TabIndex = 20;
            this.btnedit.Text = "Modificar";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // cbcargo
            // 
            this.cbcargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbcargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(532, 150);
            this.cbcargo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(217, 29);
            this.cbcargo.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbSeries.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.tbSubs.ResumeLayout(false);
            this.tbSubs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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