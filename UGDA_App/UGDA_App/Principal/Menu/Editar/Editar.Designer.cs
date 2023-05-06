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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreSerie = new System.Windows.Forms.TextBox();
            this.AddSeries = new System.Windows.Forms.Button();
            this.ModSeries = new System.Windows.Forms.Button();
            this.cbSecciones = new System.Windows.Forms.ComboBox();
            this.dgvseries = new System.Windows.Forms.DataGridView();
            this.tbSubseries = new System.Windows.Forms.TabPage();
            this.dgvsubseries = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.addSub = new System.Windows.Forms.Button();
            this.ModSub = new System.Windows.Forms.Button();
            this.cbSer = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).BeginInit();
            this.tbSubseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbSeries);
            this.tabControl1.Controls.Add(this.tbSubseries);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
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
            this.tbSeries.Controls.Add(this.label1);
            this.tbSeries.Controls.Add(this.txtNombreSerie);
            this.tbSeries.Controls.Add(this.AddSeries);
            this.tbSeries.Controls.Add(this.ModSeries);
            this.tbSeries.Controls.Add(this.cbSecciones);
            this.tbSeries.Controls.Add(this.dgvseries);
            this.tbSeries.Location = new System.Drawing.Point(4, 54);
            this.tbSeries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSeries.Size = new System.Drawing.Size(786, 448);
            this.tbSeries.TabIndex = 0;
            this.tbSeries.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre Serie:";
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
            // txtNombreSerie
            // 
            this.txtNombreSerie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreSerie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreSerie.Location = new System.Drawing.Point(239, 80);
            this.txtNombreSerie.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombreSerie.MaxLength = 200;
            this.txtNombreSerie.Name = "txtNombreSerie";
            this.txtNombreSerie.Size = new System.Drawing.Size(344, 25);
            this.txtNombreSerie.TabIndex = 15;
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
            this.AddSeries.Text = "Guardar";
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
            this.ModSeries.Text = "Editar";
            this.ModSeries.UseVisualStyleBackColor = false;
            this.ModSeries.Click += new System.EventHandler(this.ModSeries_Click);
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
            this.dgvseries.Location = new System.Drawing.Point(46, 195);
            this.dgvseries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvseries.Name = "dgvseries";
            this.dgvseries.ReadOnly = true;
            this.dgvseries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvseries.RowTemplate.Height = 41;
            this.dgvseries.Size = new System.Drawing.Size(678, 209);
            this.dgvseries.TabIndex = 10;
            this.dgvseries.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvseries_CellMouseClick);
            // 
            // tbSubseries
            // 
            this.tbSubseries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tbSubseries.Controls.Add(this.dgvsubseries);
            this.tbSubseries.Controls.Add(this.label7);
            this.tbSubseries.Controls.Add(this.label4);
            this.tbSubseries.Controls.Add(this.label6);
            this.tbSubseries.Controls.Add(this.txtCod);
            this.tbSubseries.Controls.Add(this.txtSub);
            this.tbSubseries.Controls.Add(this.addSub);
            this.tbSubseries.Controls.Add(this.ModSub);
            this.tbSubseries.Controls.Add(this.cbSer);
            this.tbSubseries.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSubseries.Location = new System.Drawing.Point(4, 54);
            this.tbSubseries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubseries.Name = "tbSubseries";
            this.tbSubseries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubseries.Size = new System.Drawing.Size(786, 448);
            this.tbSubseries.TabIndex = 1;
            this.tbSubseries.Text = "SubSeries";
            // 
            // dgvsubseries
            // 
            this.dgvsubseries.AllowUserToAddRows = false;
            this.dgvsubseries.AllowUserToDeleteRows = false;
            this.dgvsubseries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsubseries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvsubseries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvsubseries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvsubseries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubseries.GridColor = System.Drawing.Color.Peru;
            this.dgvsubseries.Location = new System.Drawing.Point(46, 195);
            this.dgvsubseries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvsubseries.Name = "dgvsubseries";
            this.dgvsubseries.ReadOnly = true;
            this.dgvsubseries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvsubseries.RowTemplate.Height = 41;
            this.dgvsubseries.Size = new System.Drawing.Size(678, 209);
            this.dgvsubseries.TabIndex = 10;
            this.dgvsubseries.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsubseries_CellMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(113, 125);
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
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre SubSerie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(119, 25);
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
            this.txtCod.Location = new System.Drawing.Point(200, 125);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCod.MaxLength = 5;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(344, 25);
            this.txtCod.TabIndex = 22;
            // 
            // txtSub
            // 
            this.txtSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSub.Location = new System.Drawing.Point(200, 75);
            this.txtSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSub.MaxLength = 200;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(344, 25);
            this.txtSub.TabIndex = 21;
            // 
            // addSub
            // 
            this.addSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addSub.Location = new System.Drawing.Point(620, 103);
            this.addSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addSub.Name = "addSub";
            this.addSub.Size = new System.Drawing.Size(100, 33);
            this.addSub.TabIndex = 20;
            this.addSub.Text = "Guardar";
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
            this.ModSub.Location = new System.Drawing.Point(620, 41);
            this.ModSub.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ModSub.Name = "ModSub";
            this.ModSub.Size = new System.Drawing.Size(100, 33);
            this.ModSub.TabIndex = 19;
            this.ModSub.Text = "Editar";
            this.ModSub.UseVisualStyleBackColor = false;
            this.ModSub.Click += new System.EventHandler(this.ModSub_Click);
            // 
            // cbSer
            // 
            this.cbSer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSer.DropDownHeight = 300;
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
            this.tabControl1.ResumeLayout(false);
            this.tbSeries.ResumeLayout(false);
            this.tbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).EndInit();
            this.tbSubseries.ResumeLayout(false);
            this.tbSubseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubseries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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