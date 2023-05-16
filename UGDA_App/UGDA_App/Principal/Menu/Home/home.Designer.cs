namespace UGDA_App
{
    partial class home
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
            lbtitulo = new Label();
            lbNombreU = new Label();
            SuspendLayout();
            // 
            // lbtitulo
            // 
            lbtitulo.BackColor = Color.FromArgb(0, 27, 89);
            lbtitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbtitulo.ForeColor = Color.WhiteSmoke;
            lbtitulo.Location = new Point(1, 171);
            lbtitulo.Margin = new Padding(2, 0, 2, 0);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(795, 47);
            lbtitulo.TabIndex = 6;
            lbtitulo.Text = "Bienvenido/a";
            lbtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lbtitulo.Click += lbtitulo_Click;
            // 
            // lbNombreU
            // 
            lbNombreU.BackColor = Color.FromArgb(0, 27, 89);
            lbNombreU.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreU.ForeColor = Color.WhiteSmoke;
            lbNombreU.Location = new Point(1, 218);
            lbNombreU.Margin = new Padding(2, 0, 2, 0);
            lbNombreU.Name = "lbNombreU";
            lbNombreU.Size = new Size(795, 47);
            lbNombreU.TabIndex = 7;
            lbNombreU.Text = "Usuario/a";
            lbNombreU.TextAlign = ContentAlignment.MiddleCenter;
            lbNombreU.Click += lbNombreU_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 27, 89);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(795, 460);
            Controls.Add(lbNombreU);
            Controls.Add(lbtitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "home";
            Text = "inicio";
            Load += home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbtitulo;
        public Label lbNombreU;
    }
}