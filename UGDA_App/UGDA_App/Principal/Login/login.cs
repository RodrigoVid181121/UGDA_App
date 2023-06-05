using Entidades.Usuarios;
using LogicaNegocios.Usuarios;
using LogicaNegocios.Encrypt;

namespace UGDA_App
{
    public partial class login : Form
    {
        ClsUsuario objUsuario = null;
        ClsUsuarioLn objUser = new ClsUsuarioLn();
        main frMain = new main();
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
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                objUsuario = new ClsUsuario()
                {
                    Carnet = txtuser.Text,
                    Contraseña = ClsEncrypt.GETSHA256(txtpass.Text)
                };

                objUser.Login(ref objUsuario);

                if (objUsuario.ErrorMessage == null)
                {
                    if (objUsuario.Id_cargo == 1 || objUsuario.Id_cargo == 2)
                    {
                        frMain.Show();
                        this.Hide();
                    }
                    else if (objUsuario.Id_cargo == 3 || objUsuario.Id_cargo == 4)
                    {
                        frMain.btnbitacora.Visible = false;
                        frMain.btnuser.Visible = false;
                        frMain.btn_Edit.Visible = false;
                        frMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show(objUsuario.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (txtuser.Text == "")
            {
                errorProvider1.SetError(txtuser, "Por favor complete este campo para continuar");
            }
            else if (txtpass.Text == "")
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