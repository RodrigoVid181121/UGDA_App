﻿using Entidades.Documentos;
using Entidades.Subseries;
using Entidades.UnidadesProductoras;
using Entidades.Usuarios;
using LogicaNegocios.Documentos;
using LogicaNegocios.Subseries;
using LogicaNegocios.Unidad_Productora;
using LogicaNegocios;
using LogicaNegocios.Validaciones;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Html2pdf;
using iText.Kernel.Geom;

namespace UGDA_App
{
    public partial class documents : Form
    {
        #region Declaración de variables
        private ClsDocument objDocument = null;
        private ClsUsuario objUser = null;
        private ClsSubSerie objSubSerie = null;
        private ClsUnidadProductora objUnidad = null;
        private readonly ClsDocumentLn objDocumentLn = new ClsDocumentLn();
        private ClsSubseriesLn objSubLn = new ClsSubseriesLn();
        private ClsUnidadLn objUnit = new ClsUnidadLn();
        Validaciones val = new Validaciones();
        int pc;
        string name;
        #endregion
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

                dgvbuscar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
                    MessageBox.Show("El código: " + codigo + " fue añadido con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("El código: " + codigo + " fue actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void button2_Click(object sender, EventArgs e)
        {
            Task task = new Task(GenerateReport);
            task.Start();
            await task;
        }

        private void GenerateReport()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Reportes\";

            name = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", Global.nombre_usuario);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvbuscar.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Serie"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subserie"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Unidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripción"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Codigo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Año"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Ubicación"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

            var ubi = System.IO.Path.Combine(path, name);
            //Creamos un nuevo documento y lo definimos como PDF
            using (var pdfWriter = new PdfWriter(ubi))
            {
                using (var pdf = new PdfDocument(pdfWriter))
                {
                    var doc = new Document(pdf, PageSize.A4);
                    doc.SetMargins(25, 25, 25, 25);
                    doc.Add(new Paragraph(""));
                    ConverterProperties converterProperties = new ConverterProperties();
                    HtmlConverter.ConvertToPdf(PaginaHTML_Texto, pdf, converterProperties);
                    MessageBox.Show("El documento se creó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    doc.Close();
                }

            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"ID LIKE '%{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 1)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Año LIKE '%{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 2)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Ubicación LIKE '%{txtbuscar.Text}%'";
            }
            if (cmbfiltro.SelectedIndex == 3)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Descripción LIKE '%{txtbuscar.Text}%'";
            }
            if (cmbfiltro.SelectedIndex == 4)
            {
                objDocument.DtResults.DefaultView.RowFilter = $"Unidad LIKE '%{txtbuscar.Text}%'";
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
