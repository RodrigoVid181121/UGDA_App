using Entidades.Documentos;
using Entidades.Series;
using Entidades.Subseries;
using Entidades.UnidadesProductoras;
using Entidades.Usuarios;
using LogicaNegocios.Documentos;
using System.Data;
using System.Windows.Forms;

namespace UGDA_App
{
    public partial class documents : Form
    {
        private ClsDocument objDocument = null;
        private ClsUsuario objUser = null;
        private ClsSerie objSerie = null;
        private ClsSubSerie objSubSerie = null;
        private ClsUnidadProductora objUnidad = null;
        private readonly ClsDocumentLn objDocumentLn = new ClsDocumentLn();
        DataTable dt = new DataTable();
        //Documentos doc = new Documentos();
        //Validaciones val = new Validaciones();
        int pc;
        public documents()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;
            if (MessageBox.Show("¿Está seguro que desea eliminar el documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
              
            }

        }

        private void limpiar()
        {
            txtubicacion.Clear();
            txtdescripcion.Clear();
            txtcod.Clear();
            txtaño.Clear();
            cbSubS.Text = "";
            cbUnidad.Text = "";
        }

        private void cargarTabla()
        {
            objDocument = new ClsDocument();
            objDocumentLn.Index(ref objDocument);

            if(objDocument.ErrorMessage == null)
            {
                //dt = doc.MostrarBuscarUsuario();
                dgvbuscar.DataSource = objDocument.DtResults;
                dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvbuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                MessageBox.Show(objDocument.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void documents_Load(object sender, EventArgs e)
        {
            txtcod.Visible = false;
            
            cmbfiltro.SelectedIndex = 0;
            //doc.llenarcbsubseries(cbSubS);
            //doc.llenarcbunidades(cbUnidad);
        }
        private void tabbus_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {            
            string codigo = txtcod.Text.Trim();
            if (cbSubS.Text != "" && cbUnidad.Text != "" && txtubicacion.Text.Trim() != "" && txtaño.Text.Trim() != "" && txtdescripcion.Text.Trim() != "")
            {
                objDocument = new ClsDocument()
                {
                    Descripcion = txtdescripcion.Text,
                    Año = txtaño.Text,
                    Ubicación = txtubicacion.Text
                };
                objUser = new ClsUsuario()
                {
                    Carnet = codigo
                };
                objUnidad = new ClsUnidadProductora()
                {
                    Nombre_unidad_productora = cbUnidad.Text
                };
                objSubSerie = new ClsSubSerie()
                {
                    Nombresubserie = cbSubS.Text
                };

                objDocumentLn.Create(ref objDocument, ref objUnidad, ref objUser, ref objSubSerie);

                if(objDocument.ErrorMessage == null) 
                {
                    MessageBox.Show("El código" + objDocument.CodigoDoc + "fue añadido con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show(objDocument.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtcod.Text.Trim();
            if (cbSubS.Text != "" && cbUnidad.Text != "" && txtubicacion.Text.Trim() != "" && txtaño.Text.Trim() != "" && txtdescripcion.Text.Trim() != "")
            {
                //if (doc.ActualizarDoc(cbSubS.Text.Trim(), cbUnidad.Text.Trim(), codigo.Trim(), txtubicacion.Text.Trim(), txtaño.Text.Trim(), txtdescripcion.Text.Trim(), Global.carnet_usuario))
                //{
                //    MessageBox.Show("Se ha modificado el documento " + Global.codigo_documento, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    limpiar();
                //    cargarTabla();
                //}
                //else
                //{
                //    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void cbSubS_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbSubS_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbSubS_TextUpdate(object sender, EventArgs e)
        {
        }

        private void cbSubS_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dgvbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;

            cbSubS.Text = dgvbuscar[2, pc].Value.ToString();
            cbUnidad.Text = dgvbuscar[3, pc].Value.ToString();
            //string a = txtbuscar.Text;
            //string b = string.Empty;
            //string c = string.Empty;
            //int val;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (Char.IsDigit(a[i]))
            //        b += a[i];
            //    else
            //        c += a[i];
            //}

            //if (b.Length > 0)
            //    val = int.Parse(b);

            //Global.codigo_documento = dgvbuscar[5, pc].Value.ToString();
            txtcod.Text = dgvbuscar[5, pc].Value.ToString();
            txtdescripcion.Text = dgvbuscar[6, pc].Value.ToString();
            txtaño.Text = dgvbuscar[7, pc].Value.ToString();
            txtubicacion.Text = dgvbuscar[8, pc].Value.ToString();


        }

        private void txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"ID LIKE '{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 1)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Año LIKE '{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 2)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Ubicación LIKE '{txtbuscar.Text}%'";
            }
            if (cmbfiltro.SelectedIndex == 3)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Descripción LIKE '{txtbuscar.Text}%'";
            }
        }

        private void txtubicacion_TextChanged(object sender, EventArgs e)
        {
            //if (val.ubicacion(txtubicacion.Text) == false)
            //{
            //    errorProvider1.SetError(txtubicacion, "Ubicacion Invalida. \n Debe contener el formato:s BX-EX-FX-CX");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("este es el id del usuario log: " + Global.carnet_usuario);
        //}

        private void txtaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider1.SetError(txtaño, "Solo se admiten números");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }
        }
    }
}
