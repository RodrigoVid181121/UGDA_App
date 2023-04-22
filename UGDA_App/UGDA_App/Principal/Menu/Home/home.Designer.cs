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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbNombreU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.lbtitulo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbtitulo.Location = new System.Drawing.Point(1, 171);
            this.lbtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(795, 47);
            this.lbtitulo.TabIndex = 6;
            this.lbtitulo.Text = "Bienvenido/a";
            this.lbtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbtitulo.Click += new System.EventHandler(this.lbtitulo_Click);
            // 
            // lbNombreU
            // 
            this.lbNombreU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.lbNombreU.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNombreU.Location = new System.Drawing.Point(1, 218);
            this.lbNombreU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombreU.Name = "lbNombreU";
            this.lbNombreU.Size = new System.Drawing.Size(795, 47);
            this.lbNombreU.TabIndex = 7;
            this.lbNombreU.Text = "Usuario/a";
            this.lbNombreU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNombreU.Click += new System.EventHandler(this.lbNombreU_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(795, 460);
            this.Controls.Add(this.lbNombreU);
            this.Controls.Add(this.lbtitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "home";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbtitulo;
        private Label lbNombreU;
    }
}