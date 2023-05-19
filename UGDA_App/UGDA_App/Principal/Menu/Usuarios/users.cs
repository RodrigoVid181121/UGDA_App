using Entidades.Cargos;
using Entidades.Usuarios;
using LogicaNegocios.Encrypt;
using LogicaNegocios.Usuarios;
using LogicaNegocios.Validaciones;
using System.Data;

namespace UGDA_App
{
    public partial class users : Form
    {

        int pc;
        DataTable dt = new DataTable();

        ClsUsuario objUsu = null;
        ClsCargo objCargo = null;
        ClsUsuarioLn objUser = new ClsUsuarioLn();

        Validaciones vl = new Validaciones();


        public users()
        {
            InitializeComponent();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)
        {
            cargarCb_Cargos();
            cargarTabla();
        }

        public void cargarCb_Cargos()
        {
            objCargo = new ClsCargo();
            objUser.FillCB(ref objCargo);

            if (objCargo.ErrorMessage == null)
            {
                cbcargo.DataSource = objCargo.DtResults;
                cbcargo.DisplayMember = "Cargo";
                cbcargo.ValueMember = "ID";
                cbcargo.SelectedIndex = -1;
            }
        }

        public void cargarTabla()
        {
            objUsu = new ClsUsuario();
            objUser.Index(ref objUsu);

            if (objUsu.ErrorMessage == null)
            {
                dgvbuscar.DataSource = objUsu.DtResults;
                dgvbuscar.Columns[0].Visible = false;
                dgvbuscar.Columns[1].Visible = false;
            }
            else
            {
                MessageBox.Show(objUsu.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            txtnom.Clear();
            txtBuscar.Clear();
            txtapellido.Clear();
            txtcarnet.Clear();
            cbcargo.SelectedIndex = -1;
            txtcorreo.Clear();
            txtBuscar.Clear();
            txtcorreo.Clear();
            txtcontra.Clear();
            txtConf.Clear();
        }

        private void tbSubs_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cbcargo.Text == "" || txtnom.Text == "" || txtapellido.Text == "" || txtcorreo.Text == "" || txtcarnet.Text == "" || txtcontra.Text == "" || txtConf.Text == "")
            {
                MessageBox.Show("Por favor rellene todos los campos para continuar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtConf.Text == txtcontra.Text)
                {
                    objUsu = new ClsUsuario()
                    {
                        Nombre = txtnom.Text,
                        Apellido = txtapellido.Text,
                        Correo = txtcorreo.Text,
                        Carnet = txtcarnet.Text,
                        Contraseña = ClsEncrypt.GETSHA256(txtcontra.Text)
                    };
                    objCargo = new ClsCargo()
                    {
                        NombreCargo = cbcargo.Text
                    };

                    objUser.Create(ref objUsu, ref objCargo);

                    if (objUsu.ErrorMessage == null && objCargo.ErrorMessage == null)
                    {
                        MessageBox.Show("El usuario fue añadido con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTabla();
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(objUsu.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(objCargo.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (txtcarnet.Text != "")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    objUsu = new ClsUsuario()
                    {
                        Carnet = txtcarnet.Text
                    };
                    objUser.Delete(ref objUsu);

                    if (objUsu.ErrorMessage == null)
                    {
                        MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarTabla();
                    }
                    else
                    {
                        MessageBox.Show(objUsu.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();

                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario en la tabla para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            //if (vl.email(txtcorreo.Text) == false)
            //{
            //    errorProvider1.SetError(txtcorreo, "Correo invalido");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (cbcargo.Text == "" || txtnom.Text == "" || txtapellido.Text == "" || txtcorreo.Text == "" || txtcarnet.Text == "" || txtcontra.Text == "" || txtConf.Text == "")
            {
                MessageBox.Show("Por favor rellene todos los campos para continuar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (txtConf.Text.Trim() == txtcontra.Text.Trim())
                    {
                        objUsu = new ClsUsuario()
                        {
                            Nombre = txtnom.Text,
                            Apellido = txtapellido.Text,
                            Correo = txtcorreo.Text,
                            Carnet = txtcarnet.Text,
                            Contraseña = ClsEncrypt.GETSHA256(txtcontra.Text)
                        };
                        objCargo = new ClsCargo()
                        {
                            NombreCargo = cbcargo.Text
                        };

                        objUser.Update(ref objUsu, ref objCargo);

                        if (objUsu.ErrorMessage == null && objCargo.ErrorMessage == null)
                        {
                            MessageBox.Show("El usuario fue actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTabla();
                            Limpiar();

                        }
                        else
                        {
                            MessageBox.Show(objUsu.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(objCargo.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgvbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;
            cbcargo.Text = dgvbuscar[6, pc].Value.ToString();
            txtnom.Text = dgvbuscar[3, pc].Value.ToString();
            txtapellido.Text = dgvbuscar[4, pc].Value.ToString();
            txtcarnet.Text = dgvbuscar[2, pc].Value.ToString();
            txtcorreo.Text = dgvbuscar[5, pc].Value.ToString();
        }

        private void pcView_Click(object sender, EventArgs e)
        {
            if (txtcontra.PasswordChar == '*')
            {
                txtcontra.PasswordChar = '\0';
            }
            else
            {
                txtcontra.PasswordChar = '*';
            }
        }

        private void pcView2_Click(object sender, EventArgs e)
        {
            if (txtConf.PasswordChar == '*')
            {
                txtConf.PasswordChar = '\0';
            }
            else
            {
                txtConf.PasswordChar = '*';
            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            var Random = new Random();
            string num = null;
            for (int i = 0; i < 4; i++)
            {
                num += Random.Next(0, 9).ToString();
            }
            string ap = txtapellido.Text.Substring(0, 1);
            string nom = txtnom.Text.Substring(0, 1);
            string carnet = ap + nom + num;
            txtcarnet.Text = carnet;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = $"Carnet LIKE '{txtBuscar.Text}%'";
            }
            else if (cmbfiltro.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = $"Nombre LIKE '{txtBuscar.Text}%'";
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            if (vl.email(txtcorreo.Text) == false)
            {
                errorProvider1.SetError(txtcorreo, "Correo invalido");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
