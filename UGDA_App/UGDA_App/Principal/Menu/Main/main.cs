using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UGDA_App.Forms;
//using UGDA_App.Forms.Clases;

namespace UGDA_App
{

    public partial class main : Form
    {

        
        public main()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            //lbUser.Text = Global.carnet_usuario;
            home frm = new home();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnInicio.Height;
            pnNav.Top = btnInicio.Top;
            pnNav.Left = btnInicio.Left;
            btnInicio.ForeColor = Color.WhiteSmoke;
            lbtitulo.Text = "Inicio";
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            home frm = new home();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            pnNav.Height = btndocs.Height;
            pnNav.Top = btndocs.Top;
            pnNav.Left = btndocs.Left;
            btndocs.ForeColor = Color.WhiteSmoke;
            lbtitulo.Text = "Documentos";
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            documents frm = new documents();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnuser.Height;
            pnNav.Top = btnuser.Top;
            pnNav.Left = btnuser.Left;
            btnuser.ForeColor = Color.WhiteSmoke;
            lbtitulo.Text = "Usuarios";
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            users frm = new users();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }
        private void btnbitacora_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnbitacora.Height;
            pnNav.Top = btnbitacora.Top;
            pnNav.Left = btnbitacora.Left;
            btnbitacora.ForeColor = Color.WhiteSmoke;
            lbtitulo.Text = "Bitacora";
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            history frm = new history();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }

        private void btnInicio_MouseHo(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btnInicio.Height;
            pnNav.Top = btnInicio.Top;
            pnNav.Left = btnInicio.Left;
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btnInicio.Height;
            pnNav.Top = btnInicio.Top;
            pnNav.Left = btnInicio.Left;
        }

        private void btndocs_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btndocs.Height;
            pnNav.Top = btndocs.Top;
            pnNav.Left = btndocs.Left;
        }

        private void btnuser_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btnuser.Height;
            pnNav.Top = btnuser.Top;
            pnNav.Left = btnuser.Left;
        }

        private void btnbitacora_MouseEnter(object sender, EventArgs e)
        {

            pnNav.Height = btnbitacora.Height;
            pnNav.Top = btnbitacora.Top;
            pnNav.Left = btnbitacora.Left;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btnCerrar.Height;
            pnNav.Top = btnCerrar.Top;
            pnNav.Left = btnCerrar.Left;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            pnNav.Height = btn_Edit.Height;
            pnNav.Top = btn_Edit.Top;
            pnNav.Left = btn_Edit.Left;
            btn_Edit.ForeColor = Color.WhiteSmoke;
            lbtitulo.Text = "Editar";
            if (pnPri.Controls.Count > 0) { pnPri.Controls.RemoveAt(0); }
            Editar frm = new Editar();
            frm.TopLevel = false;
            pnPri.Controls.Add(frm);
            frm.Show();
        }

        private void btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            pnNav.BackColor = Color.FromArgb(33, 150, 243);
            pnNav.Height = btn_Edit.Height;
            pnNav.Top = btn_Edit.Top;
            pnNav.Left = btn_Edit.Left;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
