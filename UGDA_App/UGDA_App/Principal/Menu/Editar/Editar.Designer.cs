﻿namespace UGDA_App.Forms
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
            label2 = new Label();
            label1 = new Label();
            txtAñadir = new TextBox();
            AddSeries = new Button();
            ModSeries = new Button();
            cbSeries = new ComboBox();
            cbSecciones = new ComboBox();
            dgvseries = new DataGridView();
            tbSubseries = new TabPage();
            dgvsub = new DataGridView();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCod = new TextBox();
            txtSub = new TextBox();
            addSub = new Button();
            ModSub = new Button();
            cbSub = new ComboBox();
            cbSer = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvseries).BeginInit();
            tbSubseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsub).BeginInit();
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
            tbSeries.Controls.Add(label2);
            tbSeries.Controls.Add(label1);
            tbSeries.Controls.Add(txtAñadir);
            tbSeries.Controls.Add(AddSeries);
            tbSeries.Controls.Add(ModSeries);
            tbSeries.Controls.Add(cbSeries);
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
            label3.Location = new Point(88, 126);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 31;
            label3.Text = "Nombre Serie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 30;
            label2.Text = "Series:";
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
            // txtAñadir
            // 
            txtAñadir.BackColor = Color.WhiteSmoke;
            txtAñadir.BorderStyle = BorderStyle.None;
            txtAñadir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtAñadir.Location = new Point(239, 126);
            txtAñadir.Margin = new Padding(2, 1, 2, 1);
            txtAñadir.MaxLength = 200;
            txtAñadir.Name = "txtAñadir";
            txtAñadir.Size = new Size(344, 25);
            txtAñadir.TabIndex = 15;
            txtAñadir.TextChanged += txtAñadir_TextChanged;
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
            AddSeries.Text = "Añadir";
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
            ModSeries.Text = "Modificar";
            ModSeries.UseVisualStyleBackColor = false;
            ModSeries.Click += ModSeries_Click;
            // 
            // cbSeries
            // 
            cbSeries.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSeries.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSeries.BackColor = Color.WhiteSmoke;
            cbSeries.DropDownHeight = 300;
            cbSeries.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeries.FlatStyle = FlatStyle.Flat;
            cbSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSeries.FormattingEnabled = true;
            cbSeries.IntegralHeight = false;
            cbSeries.Location = new Point(239, 72);
            cbSeries.Margin = new Padding(2, 1, 2, 1);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(344, 29);
            cbSeries.TabIndex = 12;
            cbSeries.SelectedIndexChanged += cbSeries_SelectedIndexChanged;
            // 
            // cbSecciones
            // 
            cbSecciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSecciones.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSecciones.BackColor = Color.WhiteSmoke;
            cbSecciones.DropDownHeight = 300;
            cbSecciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSecciones.FlatStyle = FlatStyle.Flat;
            cbSecciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSecciones.FormattingEnabled = true;
            cbSecciones.IntegralHeight = false;
            cbSecciones.Location = new Point(239, 21);
            cbSecciones.Margin = new Padding(2, 1, 2, 1);
            cbSecciones.Name = "cbSecciones";
            cbSecciones.Size = new Size(344, 29);
            cbSecciones.TabIndex = 11;
            cbSecciones.SelectedIndexChanged += cbSecciones_SelectedIndexChanged;
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
            dgvseries.Location = new Point(54, 184);
            dgvseries.Margin = new Padding(2, 1, 2, 1);
            dgvseries.Name = "dgvseries";
            dgvseries.ReadOnly = true;
            dgvseries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvseries.RowTemplate.Height = 41;
            dgvseries.Size = new Size(678, 209);
            dgvseries.TabIndex = 10;
            // 
            // tbSubseries
            // 
            tbSubseries.BackColor = Color.FromArgb(0, 27, 89);
            tbSubseries.Controls.Add(dgvsub);
            tbSubseries.Controls.Add(comboBox1);
            tbSubseries.Controls.Add(label7);
            tbSubseries.Controls.Add(label4);
            tbSubseries.Controls.Add(label5);
            tbSubseries.Controls.Add(label6);
            tbSubseries.Controls.Add(txtCod);
            tbSubseries.Controls.Add(txtSub);
            tbSubseries.Controls.Add(addSub);
            tbSubseries.Controls.Add(ModSub);
            tbSubseries.Controls.Add(cbSub);
            tbSubseries.Controls.Add(cbSer);
            tbSubseries.ForeColor = SystemColors.ControlDarkDark;
            tbSubseries.Location = new Point(4, 54);
            tbSubseries.Margin = new Padding(2, 1, 2, 1);
            tbSubseries.Name = "tbSubseries";
            tbSubseries.Padding = new Padding(2, 1, 2, 1);
            tbSubseries.Size = new Size(786, 448);
            tbSubseries.TabIndex = 1;
            tbSubseries.Text = "SubSeries";
            tbSubseries.Click += tbSubseries_Click;
            // 
            // dgvsub
            // 
            dgvsub.AllowUserToAddRows = false;
            dgvsub.AllowUserToDeleteRows = false;
            dgvsub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsub.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvsub.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvsub.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvsub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsub.GridColor = Color.Peru;
            dgvsub.Location = new Point(54, 183);
            dgvsub.Margin = new Padding(2, 1, 2, 1);
            dgvsub.Name = "dgvsub";
            dgvsub.ReadOnly = true;
            dgvsub.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvsub.RowTemplate.Height = 41;
            dgvsub.Size = new Size(678, 209);
            dgvsub.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 411);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(344, 29);
            comboBox1.TabIndex = 36;
            comboBox1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(432, 126);
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
            label4.Location = new Point(19, 126);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 34;
            label4.Text = "Nombre SubSerie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(19, 72);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 33;
            label5.Text = "Sub Series:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(19, 17);
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
            txtCod.Location = new Point(519, 126);
            txtCod.Margin = new Padding(2, 1, 2, 1);
            txtCod.MaxLength = 5;
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(191, 25);
            txtCod.TabIndex = 22;
            txtCod.TextChanged += txtCod_TextChanged;
            // 
            // txtSub
            // 
            txtSub.BackColor = Color.WhiteSmoke;
            txtSub.BorderStyle = BorderStyle.None;
            txtSub.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSub.Location = new Point(200, 126);
            txtSub.Margin = new Padding(2, 1, 2, 1);
            txtSub.MaxLength = 200;
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(211, 25);
            txtSub.TabIndex = 21;
            // 
            // addSub
            // 
            addSub.BackColor = Color.FromArgb(0, 0, 64);
            addSub.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            addSub.FlatStyle = FlatStyle.Flat;
            addSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSub.ForeColor = Color.WhiteSmoke;
            addSub.Location = new Point(610, 72);
            addSub.Margin = new Padding(2, 1, 2, 1);
            addSub.Name = "addSub";
            addSub.Size = new Size(100, 33);
            addSub.TabIndex = 20;
            addSub.Text = "Añadir";
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
            ModSub.Location = new Point(610, 17);
            ModSub.Margin = new Padding(2, 1, 2, 1);
            ModSub.Name = "ModSub";
            ModSub.Size = new Size(100, 33);
            ModSub.TabIndex = 19;
            ModSub.Text = "Modificar";
            ModSub.UseVisualStyleBackColor = false;
            ModSub.Click += ModSub_Click;
            // 
            // cbSub
            // 
            cbSub.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSub.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSub.BackColor = Color.WhiteSmoke;
            cbSub.DropDownHeight = 300;
            cbSub.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSub.FlatStyle = FlatStyle.Flat;
            cbSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSub.FormattingEnabled = true;
            cbSub.IntegralHeight = false;
            cbSub.Location = new Point(200, 72);
            cbSub.Margin = new Padding(2, 1, 2, 1);
            cbSub.Name = "cbSub";
            cbSub.Size = new Size(344, 29);
            cbSub.TabIndex = 18;
            // 
            // cbSer
            // 
            cbSer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSer.BackColor = Color.WhiteSmoke;
            cbSer.DropDownHeight = 300;
            cbSer.DropDownStyle = ComboBoxStyle.DropDownList;
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
            Load += Editar_Load;
            tabControl1.ResumeLayout(false);
            tbSeries.ResumeLayout(false);
            tbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvseries).EndInit();
            tbSubseries.ResumeLayout(false);
            tbSubseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsub).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbSeries;
        private Button AddSeries;
        private Button ModSeries;
        private ComboBox cbSeries;
        private ComboBox cbSecciones;
        private DataGridView dgvseries;
        private TabPage tbSubseries;
        private TextBox txtAñadir;
        private TextBox txtSub;
        private Button addSub;
        private Button ModSub;
        private ComboBox cbSub;
        private ComboBox cbSer;
        private TextBox txtCod;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridView dgvsub;
    }
}