namespace UGDA_App.Forms
{
    partial class Editar
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
            tabControl1 = new TabControl();
            tbSeries = new TabPage();
            label3 = new Label();
            label1 = new Label();
            txtNombreSerie = new TextBox();
            AddSeries = new Button();
            ModSeries = new Button();
            cbSecciones = new ComboBox();
            dgvseries = new DataGridView();
            tbSubseries = new TabPage();
            dgvsubseries = new DataGridView();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtCod = new TextBox();
            txtSub = new TextBox();
            addSub = new Button();
            ModSub = new Button();
            cbSer = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvseries).BeginInit();
            tbSubseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsubseries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tbSeries);
            tabControl1.Controls.Add(tbSubseries);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(200, 50);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 506);
            tabControl1.TabIndex = 1;
            // 
            // tbSeries
            // 
            tbSeries.BackColor = Color.FromArgb(0, 27, 89);
            tbSeries.Controls.Add(label3);
            tbSeries.Controls.Add(label1);
            tbSeries.Controls.Add(txtNombreSerie);
            tbSeries.Controls.Add(AddSeries);
            tbSeries.Controls.Add(ModSeries);
            tbSeries.Controls.Add(cbSecciones);
            tbSeries.Controls.Add(dgvseries);
            tbSeries.Location = new Point(4, 54);
            tbSeries.Margin = new Padding(2, 1, 2, 1);
            tbSeries.Name = "tbSeries";
            tbSeries.Padding = new Padding(2, 1, 2, 1);
            tbSeries.Size = new Size(786, 448);
            tbSeries.TabIndex = 0;
            tbSeries.Text = "Series";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(88, 80);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 31;
            label3.Text = "Nombre Serie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(88, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 29;
            label1.Text = "Sección:";
            // 
            // txtNombreSerie
            // 
            txtNombreSerie.BackColor = Color.WhiteSmoke;
            txtNombreSerie.BorderStyle = BorderStyle.None;
            txtNombreSerie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreSerie.Location = new Point(239, 80);
            txtNombreSerie.Margin = new Padding(2, 1, 2, 1);
            txtNombreSerie.MaxLength = 200;
            txtNombreSerie.Name = "txtNombreSerie";
            txtNombreSerie.Size = new Size(344, 25);
            txtNombreSerie.TabIndex = 15;
            // 
            // AddSeries
            // 
            AddSeries.BackColor = Color.FromArgb(0, 0, 64);
            AddSeries.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            AddSeries.FlatStyle = FlatStyle.Flat;
            AddSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddSeries.ForeColor = Color.WhiteSmoke;
            AddSeries.Location = new Point(612, 72);
            AddSeries.Margin = new Padding(2, 1, 2, 1);
            AddSeries.Name = "AddSeries";
            AddSeries.Size = new Size(100, 33);
            AddSeries.TabIndex = 14;
            AddSeries.Text = "Guardar";
            AddSeries.UseVisualStyleBackColor = false;
            AddSeries.Click += AddSeries_Click;
            // 
            // ModSeries
            // 
            ModSeries.BackColor = Color.FromArgb(0, 0, 64);
            ModSeries.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            ModSeries.FlatStyle = FlatStyle.Flat;
            ModSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModSeries.ForeColor = Color.WhiteSmoke;
            ModSeries.Location = new Point(612, 17);
            ModSeries.Margin = new Padding(2, 1, 2, 1);
            ModSeries.Name = "ModSeries";
            ModSeries.Size = new Size(100, 33);
            ModSeries.TabIndex = 13;
            ModSeries.Text = "Editar";
            ModSeries.UseVisualStyleBackColor = false;
            ModSeries.Click += ModSeries_Click;
            // 
            // cbSecciones
            // 
            cbSecciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSecciones.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSecciones.BackColor = Color.WhiteSmoke;
            cbSecciones.DropDownHeight = 300;
            cbSecciones.FlatStyle = FlatStyle.Flat;
            cbSecciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSecciones.FormattingEnabled = true;
            cbSecciones.IntegralHeight = false;
            cbSecciones.Location = new Point(239, 21);
            cbSecciones.Margin = new Padding(2, 1, 2, 1);
            cbSecciones.Name = "cbSecciones";
            cbSecciones.Size = new Size(344, 29);
            cbSecciones.TabIndex = 11;
            // 
            // dgvseries
            // 
            dgvseries.AllowUserToAddRows = false;
            dgvseries.AllowUserToDeleteRows = false;
            dgvseries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvseries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvseries.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvseries.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvseries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvseries.GridColor = Color.Peru;
            dgvseries.Location = new Point(46, 195);
            dgvseries.Margin = new Padding(2, 1, 2, 1);
            dgvseries.Name = "dgvseries";
            dgvseries.ReadOnly = true;
            dgvseries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvseries.RowTemplate.Height = 41;
            dgvseries.Size = new Size(678, 209);
            dgvseries.TabIndex = 10;
            dgvseries.CellMouseClick += dgvseries_CellMouseClick;
            // 
            // tbSubseries
            // 
            tbSubseries.BackColor = Color.FromArgb(0, 27, 89);
            tbSubseries.Controls.Add(dgvsubseries);
            tbSubseries.Controls.Add(label7);
            tbSubseries.Controls.Add(label4);
            tbSubseries.Controls.Add(label6);
            tbSubseries.Controls.Add(txtCod);
            tbSubseries.Controls.Add(txtSub);
            tbSubseries.Controls.Add(addSub);
            tbSubseries.Controls.Add(ModSub);
            tbSubseries.Controls.Add(cbSer);
            tbSubseries.ForeColor = SystemColors.ControlDarkDark;
            tbSubseries.Location = new Point(4, 54);
            tbSubseries.Margin = new Padding(2, 1, 2, 1);
            tbSubseries.Name = "tbSubseries";
            tbSubseries.Padding = new Padding(2, 1, 2, 1);
            tbSubseries.Size = new Size(786, 448);
            tbSubseries.TabIndex = 1;
            tbSubseries.Text = "SubSeries";
            // 
            // dgvsubseries
            // 
            dgvsubseries.AllowUserToAddRows = false;
            dgvsubseries.AllowUserToDeleteRows = false;
            dgvsubseries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsubseries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvsubseries.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvsubseries.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvsubseries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsubseries.GridColor = Color.Peru;
            dgvsubseries.Location = new Point(46, 195);
            dgvsubseries.Margin = new Padding(2, 1, 2, 1);
            dgvsubseries.Name = "dgvsubseries";
            dgvsubseries.ReadOnly = true;
            dgvsubseries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvsubseries.RowTemplate.Height = 41;
            dgvsubseries.Size = new Size(678, 209);
            dgvsubseries.TabIndex = 10;
            dgvsubseries.CellMouseClick += dgvsubseries_CellMouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(113, 125);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 35;
            label7.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(19, 75);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 34;
            label4.Text = "Nombre SubSerie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(119, 25);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 32;
            label6.Text = "Series:";
            // 
            // txtCod
            // 
            txtCod.BackColor = Color.WhiteSmoke;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.CharacterCasing = CharacterCasing.Upper;
            txtCod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(200, 125);
            txtCod.Margin = new Padding(2, 1, 2, 1);
            txtCod.MaxLength = 5;
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(344, 25);
            txtCod.TabIndex = 22;
            // 
            // txtSub
            // 
            txtSub.BackColor = Color.WhiteSmoke;
            txtSub.BorderStyle = BorderStyle.None;
            txtSub.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSub.Location = new Point(200, 75);
            txtSub.Margin = new Padding(2, 1, 2, 1);
            txtSub.MaxLength = 200;
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(344, 25);
            txtSub.TabIndex = 21;
            // 
            // addSub
            // 
            addSub.BackColor = Color.FromArgb(0, 0, 64);
            addSub.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            addSub.FlatStyle = FlatStyle.Flat;
            addSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSub.ForeColor = Color.WhiteSmoke;
            addSub.Location = new Point(620, 103);
            addSub.Margin = new Padding(2, 1, 2, 1);
            addSub.Name = "addSub";
            addSub.Size = new Size(100, 33);
            addSub.TabIndex = 20;
            addSub.Text = "Guardar";
            addSub.UseVisualStyleBackColor = false;
            addSub.Click += addSub_Click;
            // 
            // ModSub
            // 
            ModSub.BackColor = Color.FromArgb(0, 0, 64);
            ModSub.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            ModSub.FlatStyle = FlatStyle.Flat;
            ModSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModSub.ForeColor = Color.WhiteSmoke;
            ModSub.Location = new Point(620, 41);
            ModSub.Margin = new Padding(2, 1, 2, 1);
            ModSub.Name = "ModSub";
            ModSub.Size = new Size(100, 33);
            ModSub.TabIndex = 19;
            ModSub.Text = "Editar";
            ModSub.UseVisualStyleBackColor = false;
            ModSub.Click += ModSub_Click;
            // 
            // cbSer
            // 
            cbSer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSer.BackColor = Color.WhiteSmoke;
            cbSer.DropDownHeight = 300;
            cbSer.FlatStyle = FlatStyle.Flat;
            cbSer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSer.FormattingEnabled = true;
            cbSer.IntegralHeight = false;
            cbSer.Location = new Point(200, 21);
            cbSer.Margin = new Padding(2, 1, 2, 1);
            cbSer.Name = "cbSer";
            cbSer.Size = new Size(344, 29);
            cbSer.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(794, 506);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Editar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
            tabControl1.ResumeLayout(false);
            tbSeries.ResumeLayout(false);
            tbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvseries).EndInit();
            tbSubseries.ResumeLayout(false);
            tbSubseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsubseries).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbSeries;
        private Button AddSeries;
        private Button ModSeries;
        private ComboBox cbSecciones;
        private TabPage tbSubseries;
        private TextBox txtNombreSerie;
        private TextBox txtSub;
        private Button addSub;
        private Button ModSub;
        private ComboBox cbSer;
        private TextBox txtCod;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
        private DataGridView dgvseries;
        private DataGridView dgvsubseries;
    }
}