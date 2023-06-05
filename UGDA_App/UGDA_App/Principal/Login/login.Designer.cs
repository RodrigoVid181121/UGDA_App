namespace UGDA_App
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            paneluser = new Panel();
            txtuser = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pcView = new PictureBox();
            txtpass = new TextBox();
            pictureBox3 = new PictureBox();
            pbIniciar = new PictureBox();
            btnExit = new Button();
            textBox3 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIniciar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 29);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(479, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 41);
            label2.TabIndex = 0;
            label2.Text = "Iniciar Sesión";
            // 
            // paneluser
            // 
            paneluser.Controls.Add(txtuser);
            paneluser.Controls.Add(pictureBox2);
            paneluser.Location = new Point(407, 124);
            paneluser.Margin = new Padding(2, 1, 2, 1);
            paneluser.Name = "paneluser";
            paneluser.Size = new Size(342, 51);
            paneluser.TabIndex = 3;
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.ButtonFace;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.CharacterCasing = CharacterCasing.Upper;
            txtuser.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.Location = new Point(71, 12);
            txtuser.Margin = new Padding(2, 1, 2, 1);
            txtuser.MaxLength = 6;
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "Usuario";
            txtuser.Size = new Size(247, 25);
            txtuser.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 12);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcView);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(407, 197);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 51);
            panel1.TabIndex = 6;
            // 
            // pcView
            // 
            pcView.Cursor = Cursors.Hand;
            pcView.Image = (Image)resources.GetObject("pcView.Image");
            pcView.Location = new Point(321, 9);
            pcView.Margin = new Padding(2, 1, 2, 1);
            pcView.Name = "pcView";
            pcView.Size = new Size(29, 28);
            pcView.SizeMode = PictureBoxSizeMode.Zoom;
            pcView.TabIndex = 9;
            pcView.TabStop = false;
            pcView.Click += pcView_Click;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.Control;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(71, 12);
            txtpass.Margin = new Padding(2, 1, 2, 1);
            txtpass.MaxLength = 20;
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "Contraseña";
            txtpass.Size = new Size(247, 25);
            txtpass.TabIndex = 7;
            txtpass.KeyPress += txtpass_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 12);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pbIniciar
            // 
            pbIniciar.Cursor = Cursors.Hand;
            pbIniciar.Image = (Image)resources.GetObject("pbIniciar.Image");
            pbIniciar.Location = new Point(425, 283);
            pbIniciar.Margin = new Padding(2, 1, 2, 1);
            pbIniciar.Name = "pbIniciar";
            pbIniciar.Size = new Size(302, 68);
            pbIniciar.SizeMode = PictureBoxSizeMode.Zoom;
            pbIniciar.TabIndex = 7;
            pbIniciar.TabStop = false;
            pbIniciar.Click += pbIniciar_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.WhiteSmoke;
            btnExit.Location = new Point(723, 15);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 25);
            btnExit.TabIndex = 8;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(137, 169);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 27, 89);
            ClientSize = new Size(794, 460);
            Controls.Add(btnExit);
            Controls.Add(pbIniciar);
            Controls.Add(panel1);
            Controls.Add(paneluser);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            paneluser.ResumeLayout(false);
            paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIniciar).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Panel paneluser;
        private TextBox txtuser;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txtpass;
        private PictureBox pictureBox3;
        private PictureBox pbIniciar;
        private Button btnExit;
        private TextBox textBox3;
        private PictureBox pcView;
        private ErrorProvider errorProvider1;
    }
}