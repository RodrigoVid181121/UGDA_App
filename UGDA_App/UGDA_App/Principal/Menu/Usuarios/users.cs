using LogicaNegocios.Usuarios;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Usuarios;
using Entidades.Cargos;
using Entidades.Series;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UGDA_App
{
    public partial class users : Form
    {

        int pc;    
        ClsCargos obCargo =new ClsCargos();
        ClsUsuario obUsu = new ClsUsuario();
        ClsUsuariosLn obUsuLn = new ClsUsuariosLn();
        Validaciones vl = new Validaciones();
        public users()
        {
            InitializeComponent();
        }
        private void users_Load(object sender, EventArgs e)
        {
            CargarTabla();
            CargarCargos();
        }

        public void CargarTabla()
        {
            obUsu = new ClsUsuario();
            obUsuLn.Index(ref obUsu);
            if (obUsu.ErrorMessage == null)
            {
                dgvbuscar.DataSource = obUsu.DtResults;
                dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvbuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvbuscar.Columns[3].Visible = false;
            }
            else
            {
                MessageBox.Show(obUsu.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarCargos()
        {
            obCargo = new ClsCargos();
            obUsuLn.FillCB(ref obCargo);
            if (obUsu.ErrorMessage == null)
            {
                cbcargo.DataSource = obUsu.DtResults;
                cbcargo.DisplayMember = "Cargo";
                cbcargo.ValueMember = "ID";
                cbcargo.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(obCargo.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CrearUsuario(string nombre, string apellido, int id_cargo, string correo, string contraseña, string carnet)
        {
            
                obUsu = new ClsUsuario();
                obUsu.Nombre = nombre;
                obUsu.Apellido = apellido;
                obUsu.Id_cargo = id_cargo;
                obUsu.Correo = correo;
                obUsu.Contraseña = contraseña;
                obUsu.Carnet = carnet;
                obUsuLn.Create(ref obUsu);
                if (obUsu.ErrorMessage == null)
                {
                    Limpiar();
                    MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCargos();
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show(obUsu.ErrorMessage, "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        private void EliminarUsuario(string carnet)
        {

            obUsu = new ClsUsuario();           
            obUsu.Carnet = carnet;
            obUsuLn.Delete(ref obUsu);
            if (obUsu.ErrorMessage == null)
            {
                Limpiar();
                MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCargos();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(obUsu.ErrorMessage, "Error al eliminar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarUsuario(string nombre, string apellido, string correo, string contraseña, string carnet)
        {

            obUsu = new ClsUsuario();
            obUsu.Nombre = nombre;
            obUsu.Apellido = apellido;
            obUsu.Correo = correo;
            obUsu.Contraseña = contraseña;
            obUsu.Carnet = carnet;
            obUsuLn.Update(ref obUsu);
            if (obUsu.ErrorMessage == null)
            {
                Limpiar();
                MessageBox.Show("Usuario actualizadp correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCargos();
                CargarTabla();
            }
            else
            {
                MessageBox.Show(obUsu.ErrorMessage, "Error al actualizar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (cbcargo.Text == "Jefe")
                    {
                        try
                        {
                            CrearUsuario(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), txtcontra.Text.Trim(), txtcarnet.Text.Trim());
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    else if (cbcargo.Text == "Subjefe")
                    {
                        try
                        {
                            CrearUsuario(txtnom.Text.Trim(), txtapellido.Text.Trim(), 2, txtcorreo.Text.Trim(), txtcontra.Text.Trim(), txtcarnet.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (cbcargo.Text == "Secretaria")
                    {
                        try
                        {
                            CrearUsuario(txtnom.Text.Trim(), txtapellido.Text.Trim(), 3, txtcorreo.Text.Trim(), txtcontra.Text.Trim(), txtcarnet.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (cbcargo.Text == "Operador")
                    {
                        try
                        {
                            CrearUsuario(txtnom.Text.Trim(), txtapellido.Text.Trim(), 4, txtcorreo.Text.Trim(), txtcontra.Text.Trim(), txtcarnet.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void txtcarnet_Leave_1(object sender, EventArgs e)
        {
            if (vl.carnet(txtcarnet.Text) == false)
            {
                errorProvider1.SetError(txtcarnet, "Carnet Inválido");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (txtcarnet.Text != "")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    EliminarUsuario(txtcarnet.Text);
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
            if (vl.email(txtcorreo.Text) == false)
            {
                errorProvider1.SetError(txtcorreo, "Correo invalido");
            }
            else
            {
                errorProvider1.Clear();
            }
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
                   EditarUsuario(txtnom.Text.Trim(), txtapellido.Text.Trim(),txtcorreo.Text.Trim(), txtcontra.Text.Trim(), txtcarnet.Text.Trim());
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
                            
                      
            }
        }

        private void dgvbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;
            cbcargo.Text = dgvbuscar[0, pc].Value.ToString();
            txtnom.Text = dgvbuscar[1, pc].Value.ToString();
            txtapellido.Text = dgvbuscar[2, pc].Value.ToString();
            txtcarnet.Text = dgvbuscar[3, pc].Value.ToString();
            txtcorreo.Text = dgvbuscar[4, pc].Value.ToString();
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

        //private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (cmbfiltro.SelectedIndex == 0)
        //    {
        //        dt.DefaultView.RowFilter = $"Carnet LIKE '{txtBuscar.Text}%'";
        //    }
        //    else if (cmbfiltro.SelectedIndex == 1)
        //    {
        //        dt.DefaultView.RowFilter = $"Nombre LIKE '{txtBuscar.Text}%'";
        //    }
        //}
    }
}
