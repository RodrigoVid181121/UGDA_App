//using UGDA_App.Forms.Clases;
using System.Runtime.InteropServices;

namespace UGDA_App
{
    public partial class login : Form
    {
        //Login ln = new Login();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
          
        }

        private void pcView_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void pbIniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text!="" && txtpass.Text!="")
            {
                //if(ln.Logeo(txtuser.Text, txtpass.Text))
                this.Hide();
            }
            else if(txtuser.Text=="")
            {
                errorProvider1.SetError(txtuser, "Por favor complete este campo para continuar");
            }
            else if(txtpass.Text=="")
            {
                errorProvider1.SetError(txtpass, "Por favor complete este campo para continuar");
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                pbIniciar_Click(sender, e);
        }
    }
}