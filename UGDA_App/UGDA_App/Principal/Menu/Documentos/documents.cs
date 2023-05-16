using Entidades.Documentos;
using Entidades.Subseries;
using Entidades.UnidadesProductoras;
using Entidades.Usuarios;
using LogicaNegocios.Documentos;
using LogicaNegocios.Subseries;
using LogicaNegocios.Unidad_Productora;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using LogicaNegocios;
using LogicaNegocios.Validaciones;

namespace UGDA_App
{
    public partial class documents : Form
    {
        private ClsDocument objDocument = null;
        private ClsUsuario objUser = null;
        private ClsSubSerie objSubSerie = null;
        private ClsUnidadProductora objUnidad = null;
        private readonly ClsDocumentLn objDocumentLn = new ClsDocumentLn();
        private ClsSubseriesLn objSubLn = new ClsSubseriesLn();
        private ClsUnidadLn objUnit = new ClsUnidadLn();
        Validaciones val = new Validaciones();
        int pc;
        public documents()
        {
            InitializeComponent();
            cargarTabla();
            cargarSeries();
            cargarUnidades();
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

            if (objDocument.ErrorMessage == null)
            {
                dgvbuscar.DataSource = objDocument.DtResults;
                dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvbuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvbuscar.Columns[9].Visible = false;
                dgvbuscar.Columns[10].Visible = false;
                dgvbuscar.Columns[11].Visible = false;
                dgvbuscar.Columns[12].Visible = false;
            }
            else
            {
                MessageBox.Show(objDocument.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cargarSeries()
        {
            objSubSerie = new ClsSubSerie();
            objSubLn.ListarSubSeries(ref objSubSerie);
            if (objSubSerie.ErrorMessage == null)
            {
                cbSubS.DataSource = objSubSerie.DtResults;
                cbSubS.DisplayMember = "SubSerie";
                cbSubS.ValueMember = "ID";
                cbSubS.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(objSubSerie.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarUnidades()
        {
            objUnidad = new ClsUnidadProductora();
            objUnit.ListarUnidades(ref objUnidad);
            if (objUnidad.ErrorMessage == null)
            {
                cbUnidad.DataSource = objUnidad.DtResults;
                cbUnidad.DisplayMember = "Nombre";
                cbUnidad.ValueMember = "ID";
                cbUnidad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(objUnidad.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
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
                    Carnet = Global.carnet_usuario
                };
                objUnidad = new ClsUnidadProductora()
                {
                    Nombre_unidad_productora = cbUnidad.Text.ToString().Trim()
                };
                objSubSerie = new ClsSubSerie()
                {
                    Nombresubserie = cbSubS.Text.ToString().Trim()
                };

                objDocumentLn.Create(ref objDocument, ref objUnidad, ref objUser, ref objSubSerie);

                if (objDocument.ErrorMessage == null)
                {
                    MessageBox.Show("El código" + codigo + "fue añadido con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla();
                    limpiar();
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

        private void dgvbuscar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;

            cbSubS.Text = dgvbuscar[2, pc].Value.ToString();
            cbUnidad.Text = dgvbuscar[3, pc].Value.ToString();
            txtcod.Text = dgvbuscar[5, pc].Value.ToString();
            txtdescripcion.Text = dgvbuscar[6, pc].Value.ToString();
            txtaño.Text = dgvbuscar[7, pc].Value.ToString();
            txtubicacion.Text = dgvbuscar[8, pc].Value.ToString();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtcod.Text.Trim();
            if (MessageBox.Show("¿Está seguro que desea eliminar el documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                objDocument = new ClsDocument()
                {
                    CodigoDoc = codigo
                };
                objUser = new ClsUsuario()
                {
                    Carnet = Global.carnet_usuario
                };

                objDocumentLn.Delete(ref objDocument, ref objUser);

                if (objDocument.ErrorMessage == null)
                {
                    MessageBox.Show("El código" + codigo + "fue eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(objDocument.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtcod.Text.Trim();
            if (cbSubS.Text != "" && cbUnidad.Text != "" && txtubicacion.Text.Trim() != "" && txtaño.Text.Trim() != "" && txtdescripcion.Text.Trim() != "")
            {
                objDocument = new ClsDocument()
                {
                    Descripcion = txtdescripcion.Text,
                    Año = txtaño.Text,
                    Ubicación = txtubicacion.Text,
                    CodigoDoc = codigo
                };
                objUser = new ClsUsuario()
                {
                    Carnet = Global.carnet_usuario
                };
                objUnidad = new ClsUnidadProductora()
                {
                    Nombre_unidad_productora = cbUnidad.Text.ToString().Trim()
                };
                objSubSerie = new ClsSubSerie()
                {
                    Nombresubserie = cbSubS.Text.ToString().Trim()
                };

                objDocumentLn.Update(ref objDocument, ref objUnidad, ref objUser, ref objSubSerie);

                if (objDocument.ErrorMessage == null)
                {
                    MessageBox.Show("El código" + codigo + "fue actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla();
                    limpiar();
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

        private void txtaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                errorProvider1.SetError(txtaño, "Solo se admiten numeros");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int altura_celdas = 35;
                int margin_left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dgvbuscar.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Blue, margin_left, top);
                    margin_left += col.Width;
                }
                margin_left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, margin_left, top + 40, ep.MarginBounds.Right - margin_left, 3);
                top += 43;

                foreach (DataGridViewRow row in dgvbuscar.Rows)
                {
                    if (row.Index == dgvbuscar.RowCount - 1) break;
                    margin_left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, margin_left, top + 3);
                        margin_left += cell.OwningColumn.Width;
                    }
                    top += altura_celdas;
                }
            };
            ppd.ShowDialog();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
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

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point);

            foreach (DataGridViewColumn col in dgvbuscar.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, font, Brushes.Blue, new RectangleF(0, 10, 120, 20));

            }
        }

        private void txtubicacion_TextChanged(object sender, EventArgs e)
        {
            if (val.ubicacion(txtubicacion.Text) == false)
            {
                errorProvider1.SetError(txtubicacion, "Ubicacion Invalida. \n Debe contener el formato:s BX-EX-CX");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
