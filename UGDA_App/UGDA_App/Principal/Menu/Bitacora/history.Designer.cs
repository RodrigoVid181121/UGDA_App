namespace UGDA_App
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.paneluser = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgbitacora = new System.Windows.Forms.DataGridView();
            this.paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtrar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbfiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbfiltro.BackColor = System.Drawing.Color.White;
            this.cmbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbfiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Items.AddRange(new object[] {
            "Evento",
            "Usuario",
            "Fecha"});
            this.cmbfiltro.Location = new System.Drawing.Point(500, 16);
            this.cmbfiltro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(154, 29);
            this.cmbfiltro.TabIndex = 1;
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.paneluser.Controls.Add(this.txtbuscar);
            this.paneluser.Controls.Add(this.cmbfiltro);
            this.paneluser.Controls.Add(this.pictureBox2);
            this.paneluser.Controls.Add(this.label2);
            this.paneluser.Location = new System.Drawing.Point(58, 30);
            this.paneluser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(678, 57);
            this.paneluser.TabIndex = 10;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbuscar.Location = new System.Drawing.Point(65, 16);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PlaceholderText = "Buscar";
            this.txtbuscar.Size = new System.Drawing.Size(358, 25);
            this.txtbuscar.TabIndex = 6;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dgbitacora
            // 
            this.dgbitacora.AllowUserToAddRows = false;
            this.dgbitacora.AllowUserToDeleteRows = false;
            this.dgbitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgbitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgbitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgbitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbitacora.GridColor = System.Drawing.Color.Peru;
            this.dgbitacora.Location = new System.Drawing.Point(58, 101);
            this.dgbitacora.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgbitacora.Name = "dgbitacora";
            this.dgbitacora.ReadOnly = true;
            this.dgbitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgbitacora.RowTemplate.Height = 41;
            this.dgbitacora.Size = new System.Drawing.Size(678, 318);
            this.dgbitacora.TabIndex = 9;
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(795, 460);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.dgbitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.history_Load);
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private ComboBox cmbfiltro;
        private Panel paneluser;
        private TextBox txtbuscar;
        private PictureBox pictureBox2;
        private DataGridView dgbitacora;
    }
}