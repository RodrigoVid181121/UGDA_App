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
            label2 = new Label();
            cmbfiltro = new ComboBox();
            paneluser = new Panel();
            txtbuscar = new TextBox();
            pictureBox2 = new PictureBox();
            dgbitacora = new DataGridView();
            paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgbitacora).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(427, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 7;
            label2.Text = "Filtrar:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbfiltro
            // 
            cmbfiltro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbfiltro.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbfiltro.BackColor = Color.White;
            cmbfiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfiltro.FlatStyle = FlatStyle.Flat;
            cmbfiltro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbfiltro.FormattingEnabled = true;
            cmbfiltro.Items.AddRange(new object[] { "Evento", "Usuario", "Fecha" });
            cmbfiltro.Location = new Point(500, 16);
            cmbfiltro.Margin = new Padding(2, 1, 2, 1);
            cmbfiltro.Name = "cmbfiltro";
            cmbfiltro.Size = new Size(154, 29);
            cmbfiltro.TabIndex = 1;
            // 
            // paneluser
            // 
            paneluser.BackColor = Color.FromArgb(0, 0, 40);
            paneluser.Controls.Add(txtbuscar);
            paneluser.Controls.Add(cmbfiltro);
            paneluser.Controls.Add(pictureBox2);
            paneluser.Controls.Add(label2);
            paneluser.Location = new Point(58, 30);
            paneluser.Margin = new Padding(2, 1, 2, 1);
            paneluser.Name = "paneluser";
            paneluser.Size = new Size(678, 57);
            paneluser.TabIndex = 10;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = SystemColors.ButtonFace;
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(65, 16);
            txtbuscar.Margin = new Padding(2, 1, 2, 1);
            txtbuscar.Multiline = true;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PlaceholderText = "Buscar";
            txtbuscar.Size = new Size(358, 25);
            txtbuscar.TabIndex = 6;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 16);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // dgbitacora
            // 
            dgbitacora.AllowUserToAddRows = false;
            dgbitacora.AllowUserToDeleteRows = false;
            dgbitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgbitacora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgbitacora.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgbitacora.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgbitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbitacora.GridColor = Color.Peru;
            dgbitacora.Location = new Point(58, 101);
            dgbitacora.Margin = new Padding(2, 1, 2, 1);
            dgbitacora.Name = "dgbitacora";
            dgbitacora.ReadOnly = true;
            dgbitacora.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgbitacora.RowTemplate.Height = 41;
            dgbitacora.Size = new Size(678, 318);
            dgbitacora.TabIndex = 9;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 27, 89);
            ClientSize = new Size(794, 506);
            Controls.Add(paneluser);
            Controls.Add(dgbitacora);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "history";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitacora";
            Load += history_Load;
            paneluser.ResumeLayout(false);
            paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgbitacora).EndInit();
            ResumeLayout(false);
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