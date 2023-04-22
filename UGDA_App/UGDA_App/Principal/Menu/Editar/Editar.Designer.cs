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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSeries = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAñadir = new System.Windows.Forms.TextBox();
            this.AddSeries = new System.Windows.Forms.Button();
            this.ModSeries = new System.Windows.Forms.Button();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.cbSecciones = new System.Windows.Forms.ComboBox();
            this.dgvseries = new System.Windows.Forms.DataGridView();
            this.tbSubseries = new System.Windows.Forms.TabPage();
            this.dgvsub = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.addSub = new System.Windows.Forms.Button();
            this.ModSub = new System.Windows.Forms.Button();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.cbSer = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).BeginInit();
            this.tbSubseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbSeries);
            this.tabControl1.Controls.Add(this.tbSubseries);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tbSeries
            // 
            this.tbSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tbSeries.Controls.Add(this.label3);
            this.tbSeries.Controls.Add(this.label2);
            this.tbSeries.Controls.Add(this.label1);
            this.tbSeries.Controls.Add(this.txtAñadir);
            this.tbSeries.Controls.Add(this.AddSeries);
            this.tbSeries.Controls.Add(this.ModSeries);
            this.tbSeries.Controls.Add(this.cbSeries);
            this.tbSeries.Controls.Add(this.cbSecciones);
            this.tbSeries.Controls.Add(this.dgvseries);
            this.tbSeries.Location = new System.Drawing.Point(4, 24);
            this.tbSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Size = new System.Drawing.Size(786, 478);
            this.tbSeries.TabIndex = 0;
            this.tbSeries.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(88, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre Serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Series:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sección:";
            // 
            // txtAñadir
            // 
            this.txtAñadir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAñadir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAñadir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAñadir.Location = new System.Drawing.Point(239, 126);
            this.txtAñadir.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAñadir.MaxLength = 200;
            this.txtAñadir.Name = "txtAñadir";
            this.txtAñadir.Size = new System.Drawing.Size(344, 25);
            this.txtAñadir.TabIndex = 15;
            this.txtAñadir.TextChanged += new System.EventHandler(this.txtAñadir_TextChanged);
            // 
            // AddSeries
            // 
            this.AddSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddSeries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSeries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddSeries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddSeries.Location = new System.Drawing.Point(612, 72);
            this.AddSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddSeries.Name = "AddSeries";
            this.AddSeries.Size = new System.Drawing.Size(100, 33);
            this.AddSeries.TabIndex = 14;
            this.AddSeries.Text = "Añadir";
            this.AddSeries.UseVisualStyleBackColor = false;
            this.AddSeries.Click += new System.EventHandler(this.AddSeries_Click);
            // 
            // ModSeries
            // 
            this.ModSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModSeries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModSeries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModSeries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModSeries.Location = new System.Drawing.Point(612, 17);
            this.ModSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ModSeries.Name = "ModSeries";
            this.ModSeries.Size = new System.Drawing.Size(100, 33);
            this.ModSeries.TabIndex = 13;
            this.ModSeries.Text = "Modificar";
            this.ModSeries.UseVisualStyleBackColor = false;
            this.ModSeries.Click += new System.EventHandler(this.ModSeries_Click);
            // 
            // cbSeries
            // 
            this.cbSeries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSeries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSeries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSeries.DropDownHeight = 300;
            this.cbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.IntegralHeight = false;
            this.cbSeries.Location = new System.Drawing.Point(239, 72);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(344, 29);
            this.cbSeries.TabIndex = 12;
            this.cbSeries.SelectedIndexChanged += new System.EventHandler(this.cbSeries_SelectedIndexChanged);
            // 
            // cbSecciones
            // 
            this.cbSecciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSecciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSecciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSecciones.DropDownHeight = 300;
            this.cbSecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSecciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSecciones.FormattingEnabled = true;
            this.cbSecciones.IntegralHeight = false;
            this.cbSecciones.Location = new System.Drawing.Point(239, 21);
            this.cbSecciones.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSecciones.Name = "cbSecciones";
            this.cbSecciones.Size = new System.Drawing.Size(344, 29);
            this.cbSecciones.TabIndex = 11;
            this.cbSecciones.SelectedIndexChanged += new System.EventHandler(this.cbSecciones_SelectedIndexChanged);
            // 
            // dgvseries
            // 
            this.dgvseries.AllowUserToAddRows = false;
            this.dgvseries.AllowUserToDeleteRows = false;
            this.dgvseries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvseries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvseries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvseries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvseries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseries.GridColor = System.Drawing.Color.Peru;
            this.dgvseries.Location = new System.Drawing.Point(54, 184);
            this.dgvseries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvseries.Name = "dgvseries";
            this.dgvseries.ReadOnly = true;
            this.dgvseries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvseries.RowTemplate.Height = 41;
            this.dgvseries.Size = new System.Drawing.Size(678, 209);
            this.dgvseries.TabIndex = 10;
            // 
            // tbSubseries
            // 
            this.tbSubseries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tbSubseries.Controls.Add(this.dgvsub);
            this.tbSubseries.Controls.Add(this.comboBox1);
            this.tbSubseries.Controls.Add(this.label7);
            this.tbSubseries.Controls.Add(this.label4);
            this.tbSubseries.Controls.Add(this.label5);
            this.tbSubseries.Controls.Add(this.label6);
            this.tbSubseries.Controls.Add(this.txtCod);
            this.tbSubseries.Controls.Add(this.txtSub);
            this.tbSubseries.Controls.Add(this.addSub);
            this.tbSubseries.Controls.Add(this.ModSub);
            this.tbSubseries.Controls.Add(this.cbSub);
            this.tbSubseries.Controls.Add(this.cbSer);
            this.tbSubseries.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSubseries.Location = new System.Drawing.Point(4, 24);
            this.tbSubseries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubseries.Name = "tbSubseries";
            this.tbSubseries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubseries.Size = new System.Drawing.Size(786, 478);
            this.tbSubseries.TabIndex = 1;
            this.tbSubseries.Text = "SubSeries";
            this.tbSubseries.Click += new System.EventHandler(this.tbSubseries_Click);
            // 
            // dgvsub
            // 
            this.dgvsub.AllowUserToAddRows = false;
            this.dgvsub.AllowUserToDeleteRows = false;
            this.dgvsub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvsub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvsub.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvsub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsub.GridColor = System.Drawing.Color.Peru;
            this.dgvsub.Location = new System.Drawing.Point(54, 183);
            this.dgvsub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvsub.Name = "dgvsub";
            this.dgvsub.ReadOnly = true;
            this.dgvsub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvsub.RowTemplate.Height = 41;
            this.dgvsub.Size = new System.Drawing.Size(678, 209);
            this.dgvsub.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 411);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 29);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(432, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre SubSerie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sub Series:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Series:";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCod.Location = new System.Drawing.Point(519, 126);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCod.MaxLength = 5;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(191, 25);
            this.txtCod.TabIndex = 22;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // txtSub
            // 
            this.txtSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSub.Location = new System.Drawing.Point(200, 126);
            this.txtSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSub.MaxLength = 200;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(211, 25);
            this.txtSub.TabIndex = 21;
            // 
            // addSub
            // 
            this.addSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addSub.Location = new System.Drawing.Point(610, 72);
            this.addSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addSub.Name = "addSub";
            this.addSub.Size = new System.Drawing.Size(100, 33);
            this.addSub.TabIndex = 20;
            this.addSub.Text = "Añadir";
            this.addSub.UseVisualStyleBackColor = false;
            this.addSub.Click += new System.EventHandler(this.addSub_Click);
            // 
            // ModSub
            // 
            this.ModSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModSub.Location = new System.Drawing.Point(610, 17);
            this.ModSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ModSub.Name = "ModSub";
            this.ModSub.Size = new System.Drawing.Size(100, 33);
            this.ModSub.TabIndex = 19;
            this.ModSub.Text = "Modificar";
            this.ModSub.UseVisualStyleBackColor = false;
            this.ModSub.Click += new System.EventHandler(this.ModSub_Click);
            // 
            // cbSub
            // 
            this.cbSub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSub.DropDownHeight = 300;
            this.cbSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSub.FormattingEnabled = true;
            this.cbSub.IntegralHeight = false;
            this.cbSub.Location = new System.Drawing.Point(200, 72);
            this.cbSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(344, 29);
            this.cbSub.TabIndex = 18;
            // 
            // cbSer
            // 
            this.cbSer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSer.DropDownHeight = 300;
            this.cbSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSer.FormattingEnabled = true;
            this.cbSer.IntegralHeight = false;
            this.cbSer.Location = new System.Drawing.Point(200, 21);
            this.cbSer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSer.Name = "cbSer";
            this.cbSer.Size = new System.Drawing.Size(344, 29);
            this.cbSer.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbSeries.ResumeLayout(false);
            this.tbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).EndInit();
            this.tbSubseries.ResumeLayout(false);
            this.tbSubseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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