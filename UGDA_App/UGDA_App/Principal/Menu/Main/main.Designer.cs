namespace UGDA_App
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            panel3 = new Panel();
            btnmin = new Button();
            btnmax = new Button();
            btnExit = new Button();
            lbtitulo = new Label();
            panel1 = new Panel();
            pnNav = new Panel();
            btnbitacora = new Button();
            btnCerrar = new Button();
            btnuser = new Button();
            btndocs = new Button();
            btnInicio = new Button();
            panel2 = new Panel();
            pbUser = new PictureBox();
            lbUser = new Label();
            pnPrin = new Panel();
            btn_Edit = new Button();
            pnPri = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            pnPri.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(btnmin);
            panel3.Controls.Add(btnmax);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(lbtitulo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(219, 0);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(791, 44);
            panel3.TabIndex = 3;
            // 
            // btnmin
            // 
            btnmin.BackColor = Color.FromArgb(0, 0, 64);
            btnmin.Dock = DockStyle.Right;
            btnmin.FlatAppearance.BorderColor = Color.White;
            btnmin.FlatAppearance.BorderSize = 0;
            btnmin.FlatStyle = FlatStyle.Flat;
            btnmin.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmin.ForeColor = Color.WhiteSmoke;
            btnmin.Location = new Point(692, 0);
            btnmin.Margin = new Padding(2, 1, 2, 1);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(33, 44);
            btnmin.TabIndex = 11;
            btnmin.Text = "-";
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // btnmax
            // 
            btnmax.BackColor = Color.FromArgb(0, 0, 64);
            btnmax.Dock = DockStyle.Right;
            btnmax.FlatAppearance.BorderColor = Color.White;
            btnmax.FlatAppearance.BorderSize = 0;
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmax.ForeColor = Color.WhiteSmoke;
            btnmax.Location = new Point(725, 0);
            btnmax.Margin = new Padding(2, 1, 2, 1);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(33, 44);
            btnmax.TabIndex = 10;
            btnmax.Text = "=";
            btnmax.UseVisualStyleBackColor = false;
            btnmax.Click += btnmax_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 0, 64);
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.WhiteSmoke;
            btnExit.Location = new Point(758, 0);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 44);
            btnExit.TabIndex = 9;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbtitulo
            // 
            lbtitulo.BackColor = Color.FromArgb(0, 0, 64);
            lbtitulo.Dock = DockStyle.Fill;
            lbtitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbtitulo.ForeColor = Color.WhiteSmoke;
            lbtitulo.Location = new Point(0, 0);
            lbtitulo.Margin = new Padding(2, 0, 2, 0);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(791, 44);
            lbtitulo.TabIndex = 5;
            lbtitulo.Text = "Inicio";
            lbtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pnNav);
            panel1.Controls.Add(btnbitacora);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnuser);
            panel1.Controls.Add(btndocs);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Edit);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 550);
            panel1.TabIndex = 2;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // pnNav
            // 
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Location = new Point(-1, 126);
            pnNav.Margin = new Padding(2, 1, 2, 1);
            pnNav.Name = "pnNav";
            pnNav.Size = new Size(5, 317);
            pnNav.TabIndex = 4;
            // 
            // btnbitacora
            // 
            btnbitacora.Dock = DockStyle.Top;
            btnbitacora.FlatAppearance.BorderSize = 0;
            btnbitacora.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnbitacora.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnbitacora.FlatStyle = FlatStyle.Flat;
            btnbitacora.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnbitacora.ForeColor = Color.WhiteSmoke;
            btnbitacora.Image = (Image)resources.GetObject("btnbitacora.Image");
            btnbitacora.Location = new Point(0, 314);
            btnbitacora.Margin = new Padding(2, 1, 2, 1);
            btnbitacora.Name = "btnbitacora";
            btnbitacora.Size = new Size(219, 64);
            btnbitacora.TabIndex = 6;
            btnbitacora.Text = "Bitacora       ";
            btnbitacora.TextAlign = ContentAlignment.MiddleRight;
            btnbitacora.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbitacora.UseVisualStyleBackColor = true;
            btnbitacora.Click += btnbitacora_Click;
            btnbitacora.MouseEnter += btnbitacora_MouseEnter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(0, 0, 40);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.WhiteSmoke;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(0, 486);
            btnCerrar.Margin = new Padding(2, 1, 2, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(216, 64);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "  Cerrar sesion";
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            // 
            // btnuser
            // 
            btnuser.Dock = DockStyle.Top;
            btnuser.FlatAppearance.BorderSize = 0;
            btnuser.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnuser.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnuser.FlatStyle = FlatStyle.Flat;
            btnuser.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnuser.ForeColor = Color.WhiteSmoke;
            btnuser.Image = (Image)resources.GetObject("btnuser.Image");
            btnuser.Location = new Point(0, 250);
            btnuser.Margin = new Padding(2, 1, 2, 1);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(219, 64);
            btnuser.TabIndex = 4;
            btnuser.Text = "Usuarios       ";
            btnuser.TextAlign = ContentAlignment.MiddleRight;
            btnuser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnuser.UseVisualStyleBackColor = true;
            btnuser.Click += btnuser_Click;
            btnuser.MouseEnter += btnuser_MouseEnter;
            // 
            // btndocs
            // 
            btndocs.Dock = DockStyle.Top;
            btndocs.FlatAppearance.BorderSize = 0;
            btndocs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btndocs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btndocs.FlatStyle = FlatStyle.Flat;
            btndocs.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btndocs.ForeColor = Color.WhiteSmoke;
            btndocs.Image = (Image)resources.GetObject("btndocs.Image");
            btndocs.Location = new Point(0, 188);
            btndocs.Margin = new Padding(2, 1, 2, 1);
            btndocs.Name = "btndocs";
            btndocs.Size = new Size(219, 62);
            btndocs.TabIndex = 2;
            btndocs.Text = "Documentos";
            btndocs.TextAlign = ContentAlignment.MiddleRight;
            btndocs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndocs.UseVisualStyleBackColor = true;
            btndocs.Click += btnbuscar_Click;
            btndocs.MouseEnter += btndocs_MouseEnter;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.WhiteSmoke;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(0, 126);
            btnInicio.Margin = new Padding(2, 1, 2, 1);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(219, 62);
            btnInicio.TabIndex = 1;
            btnInicio.Text = " Inicio            ";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseEnter += btnInicio_MouseEnter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 40);
            panel2.Controls.Add(pbUser);
            panel2.Controls.Add(lbUser);
            panel2.Controls.Add(pnPrin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 126);
            panel2.TabIndex = 1;
            panel2.MouseEnter += panel2_MouseEnter;
            // 
            // pbUser
            // 
            pbUser.Dock = DockStyle.Top;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(0, 0);
            pbUser.Margin = new Padding(2, 1, 2, 1);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(219, 77);
            pbUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbUser.TabIndex = 1;
            pbUser.TabStop = false;
            // 
            // lbUser
            // 
            lbUser.Dock = DockStyle.Bottom;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUser.ForeColor = Color.WhiteSmoke;
            lbUser.Location = new Point(0, 89);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(219, 37);
            lbUser.TabIndex = 0;
            lbUser.Text = "Username";
            lbUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnPrin
            // 
            pnPrin.Location = new Point(216, 44);
            pnPrin.Margin = new Padding(2, 1, 2, 1);
            pnPrin.Name = "pnPrin";
            pnPrin.Size = new Size(793, 460);
            pnPrin.TabIndex = 4;
            // 
            // btn_Edit
            // 
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.ForeColor = Color.WhiteSmoke;
            btn_Edit.Image = (Image)resources.GetObject("btn_Edit.Image");
            btn_Edit.Location = new Point(1, 371);
            btn_Edit.Margin = new Padding(2, 1, 2, 1);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(216, 64);
            btn_Edit.TabIndex = 7;
            btn_Edit.Text = "Editar";
            btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click_1;
            btn_Edit.MouseEnter += btn_Edit_MouseEnter_1;
            // 
            // pnPri
            // 
            pnPri.AutoSize = true;
            pnPri.BackColor = Color.FromArgb(0, 27, 89);
            pnPri.Controls.Add(label1);
            pnPri.Dock = DockStyle.Fill;
            pnPri.Location = new Point(219, 44);
            pnPri.Margin = new Padding(2, 1, 2, 1);
            pnPri.Name = "pnPri";
            pnPri.Size = new Size(791, 506);
            pnPri.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 27, 89);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(208, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 47);
            label1.TabIndex = 10;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 550);
            Controls.Add(pnPri);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            pnPri.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnCerrar;
        private Button btndocs;
        private Button btnInicio;
        private Panel panel2;
        private PictureBox pbUser;
        private Panel pnNav;
        private Panel pnPrin;
        private Panel pnPri;
        private Label lbUser;
        private Label lbtitulo;
        private Button btnExit;
        internal Button btnbitacora;
        internal Button btnuser;
        internal Label label1;
        private Button btnmin;
        private Button btnmax;
        internal Button btn_Edit;
    }
}