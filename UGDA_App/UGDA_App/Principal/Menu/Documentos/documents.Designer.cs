namespace UGDA_App
{
    partial class documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(documents));
            tabBuscar = new TabControl();
            tabbus = new TabPage();
            dgvbuscar = new DataGridView();
            paneluser = new Panel();
            cmbfiltro = new ComboBox();
            btneliminar = new Button();
            txtbuscar = new TextBox();
            pictureBox2 = new PictureBox();
            tabedit = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            btnguardar = new Button();
            btncancelar = new Button();
            cbUnidad = new ComboBox();
            txtdescripcion = new TextBox();
            label9 = new Label();
            txtaño = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtubicacion = new TextBox();
            txtcod = new TextBox();
            cbSubS = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            button2 = new Button();
            tabBuscar.SuspendLayout();
            tabbus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).BeginInit();
            paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabedit.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabBuscar
            // 
            tabBuscar.Appearance = TabAppearance.FlatButtons;
            tabBuscar.Controls.Add(tabbus);
            tabBuscar.Controls.Add(tabedit);
            tabBuscar.Dock = DockStyle.Fill;
            tabBuscar.ItemSize = new Size(90, 20);
            tabBuscar.Location = new Point(0, 0);
            tabBuscar.Margin = new Padding(4, 2, 4, 2);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.SelectedIndex = 0;
            tabBuscar.Size = new Size(1475, 1079);
            tabBuscar.SizeMode = TabSizeMode.Fixed;
            tabBuscar.TabIndex = 0;
            // 
            // tabbus
            // 
            tabbus.BackColor = Color.FromArgb(0, 27, 89);
            tabbus.Controls.Add(button2);
            tabbus.Controls.Add(dgvbuscar);
            tabbus.Controls.Add(paneluser);
            tabbus.Location = new Point(4, 24);
            tabbus.Margin = new Padding(4, 2, 4, 2);
            tabbus.Name = "tabbus";
            tabbus.Padding = new Padding(4, 2, 4, 2);
            tabbus.Size = new Size(1467, 1051);
            tabbus.TabIndex = 0;
            tabbus.Text = "Buscar";
            tabbus.Click += tabbus_Click;
            // 
            // dgvbuscar
            // 
            dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbuscar.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvbuscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvbuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbuscar.Location = new Point(61, 239);
            dgvbuscar.Margin = new Padding(6, 6, 6, 6);
            dgvbuscar.Name = "dgvbuscar";
            dgvbuscar.RowHeadersVisible = false;
            dgvbuscar.RowHeadersWidth = 82;
            dgvbuscar.RowTemplate.Height = 25;
            dgvbuscar.Size = new Size(1339, 604);
            dgvbuscar.TabIndex = 5;
            dgvbuscar.CellClick += dgvbuscar_CellClick;
            // 
            // paneluser
            // 
            paneluser.BackColor = Color.FromArgb(0, 0, 40);
            paneluser.Controls.Add(cmbfiltro);
            paneluser.Controls.Add(btneliminar);
            paneluser.Controls.Add(txtbuscar);
            paneluser.Controls.Add(pictureBox2);
            paneluser.Location = new Point(61, 81);
            paneluser.Margin = new Padding(4, 2, 4, 2);
            paneluser.Name = "paneluser";
            paneluser.Size = new Size(1339, 122);
            paneluser.TabIndex = 4;
            // 
            // cmbfiltro
            // 
            cmbfiltro.FormattingEnabled = true;
            cmbfiltro.Items.AddRange(new object[] { "Código", "Año", "Ubicación", "Descripción" });
            cmbfiltro.Location = new Point(793, 38);
            cmbfiltro.Margin = new Padding(6, 6, 6, 6);
            cmbfiltro.Name = "cmbfiltro";
            cmbfiltro.Size = new Size(277, 40);
            cmbfiltro.TabIndex = 9;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(0, 0, 64);
            btneliminar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.WhiteSmoke;
            btneliminar.Location = new Point(1137, 28);
            btneliminar.Margin = new Padding(4, 2, 4, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(154, 70);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = SystemColors.ButtonFace;
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(176, 34);
            txtbuscar.Margin = new Padding(4, 2, 4, 2);
            txtbuscar.Multiline = true;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PlaceholderText = "Buscar documento";
            txtbuscar.Size = new Size(579, 53);
            txtbuscar.TabIndex = 6;
            txtbuscar.TextChanged += txtbuscar_TextChanged_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 34);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tabedit
            // 
            tabedit.BackColor = Color.WhiteSmoke;
            tabedit.Controls.Add(panel1);
            tabedit.Location = new Point(4, 24);
            tabedit.Margin = new Padding(4, 2, 4, 2);
            tabedit.Name = "tabedit";
            tabedit.Padding = new Padding(4, 2, 4, 2);
            tabedit.Size = new Size(1467, 1051);
            tabedit.TabIndex = 1;
            tabedit.Text = "Formulario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 27, 89);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnguardar);
            panel1.Controls.Add(btncancelar);
            panel1.Controls.Add(cbUnidad);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtaño);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtubicacion);
            panel1.Controls.Add(txtcod);
            panel1.Controls.Add(cbSubS);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(4, 6);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 1079);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(641, 742);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(197, 81);
            button1.TabIndex = 26;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 0, 64);
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnguardar.ForeColor = Color.WhiteSmoke;
            btnguardar.Location = new Point(897, 742);
            btnguardar.Margin = new Padding(4, 2, 4, 2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(197, 81);
            btnguardar.TabIndex = 25;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(0, 0, 64);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.WhiteSmoke;
            btncancelar.Location = new Point(375, 742);
            btncancelar.Margin = new Padding(4, 2, 4, 2);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(197, 81);
            btncancelar.TabIndex = 24;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // cbUnidad
            // 
            cbUnidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUnidad.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUnidad.BackColor = Color.WhiteSmoke;
            cbUnidad.DropDownHeight = 300;
            cbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidad.FlatStyle = FlatStyle.Flat;
            cbUnidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUnidad.FormattingEnabled = true;
            cbUnidad.IntegralHeight = false;
            cbUnidad.Location = new Point(763, 117);
            cbUnidad.Margin = new Padding(4, 2, 4, 2);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(595, 53);
            cbUnidad.TabIndex = 23;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.WhiteSmoke;
            txtdescripcion.BorderStyle = BorderStyle.None;
            txtdescripcion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(82, 390);
            txtdescripcion.Margin = new Padding(4, 2, 4, 2);
            txtdescripcion.MaxLength = 255;
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(1280, 267);
            txtdescripcion.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(82, 335);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(232, 51);
            label9.TabIndex = 21;
            label9.Text = "Descripcion:";
            // 
            // txtaño
            // 
            txtaño.BackColor = Color.WhiteSmoke;
            txtaño.BorderStyle = BorderStyle.None;
            txtaño.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtaño.Location = new Point(763, 239);
            txtaño.Margin = new Padding(4, 2, 4, 2);
            txtaño.MaxLength = 4;
            txtaño.Name = "txtaño";
            txtaño.Size = new Size(598, 50);
            txtaño.TabIndex = 20;
            txtaño.KeyPress += txtaño_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(763, 183);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 51);
            label8.TabIndex = 19;
            label8.Text = "Año:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(763, 62);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(359, 51);
            label7.TabIndex = 17;
            label7.Text = "Unidad Productora:";
            // 
            // txtubicacion
            // 
            txtubicacion.BackColor = Color.WhiteSmoke;
            txtubicacion.BorderStyle = BorderStyle.None;
            txtubicacion.CharacterCasing = CharacterCasing.Upper;
            txtubicacion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtubicacion.Location = new Point(82, 239);
            txtubicacion.Margin = new Padding(4, 2, 4, 2);
            txtubicacion.MaxLength = 25;
            txtubicacion.Name = "txtubicacion";
            txtubicacion.Size = new Size(598, 50);
            txtubicacion.TabIndex = 10;
            txtubicacion.TextChanged += txtubicacion_TextChanged;
            // 
            // txtcod
            // 
            txtcod.BackColor = Color.WhiteSmoke;
            txtcod.BorderStyle = BorderStyle.None;
            txtcod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtcod.Location = new Point(82, 755);
            txtcod.Margin = new Padding(4, 2, 4, 2);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(149, 50);
            txtcod.TabIndex = 9;
            // 
            // cbSubS
            // 
            cbSubS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSubS.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSubS.BackColor = Color.WhiteSmoke;
            cbSubS.DropDownHeight = 300;
            cbSubS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubS.FlatStyle = FlatStyle.Flat;
            cbSubS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubS.FormattingEnabled = true;
            cbSubS.IntegralHeight = false;
            cbSubS.Location = new Point(82, 119);
            cbSubS.Margin = new Padding(4, 2, 4, 2);
            cbSubS.Name = "cbSubS";
            cbSubS.Size = new Size(595, 53);
            cbSubS.TabIndex = 3;
            cbSubS.SelectedIndexChanged += cbSubS_SelectedIndexChanged;
            cbSubS.SelectionChangeCommitted += cbSubS_SelectionChangeCommitted;
            cbSubS.TextUpdate += cbSubS_TextUpdate;
            cbSubS.TextChanged += cbSubS_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(82, 183);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(202, 51);
            label5.TabIndex = 6;
            label5.Text = "Ubicacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(82, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 51);
            label3.TabIndex = 4;
            label3.Text = "Sub-Serie:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(854, 866);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(498, 70);
            button2.TabIndex = 10;
            button2.Text = "Imprimir Actual";
            button2.UseVisualStyleBackColor = false;
            // 
            // documents
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1475, 1079);
            Controls.Add(tabBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "documents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buscar";
            Load += documents_Load;
            tabBuscar.ResumeLayout(false);
            tabbus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).EndInit();
            paneluser.ResumeLayout(false);
            paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabedit.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabBuscar;
        private TabPage tabbus;
        private TabPage tabedit;
        private Panel paneluser;
        private TextBox txtbuscar;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
        private Label label3;
        private TextBox txtubicacion;
        private TextBox txtcod;
        private ComboBox cbSubS;
        private Button btneliminar;
        private TextBox txtdescripcion;
        private Label label9;
        private TextBox txtaño;
        private Label label8;
        private Label label7;
        private ComboBox cbUnidad;
        private Button btnguardar;
        private Button btncancelar;
        private ComboBox cmbfiltro;
        private DataGridView dgvbuscar;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Button button2;
    }
}