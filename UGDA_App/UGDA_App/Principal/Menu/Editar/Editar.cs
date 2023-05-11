using Entidades.Series;
using LogicaNegocios.Series;
using Entidades.Subseries;
using LogicaNegocios.Subseries;


namespace UGDA_App.Forms
{
    public partial class Editar : Form
    {
        private ClsSerie objSerie;
        private ClsSeriesLn objSerieLn = new ClsSeriesLn();
        private ClsSubSerie objSub;
        private ClsSubseriesLn objSubLn = new ClsSubseriesLn();
        private int idSerie, idsubserie;

        public Editar()
        {
            InitializeComponent();
            cargarTablaSeries();
            cargarTablaSubseries();
            cargarSecciones();
            cargarSeries();
            
        }

        public void LimpiarSerie()
        {
            cbSecciones.Text = "";
            txtNombreSerie.Clear();
        }
        public void LimpiarSubserie()
        {
            cbSer.Text = "";
            txtCod.Clear();
            txtSub.Clear();
        }

        private void cargarTablaSeries()
        {
            objSerie = new ClsSerie();
            objSerieLn.Index(ref objSerie);

            if (objSerie.ErrorMessage == null)
            {
                dgvseries.DataSource = objSerie.DtResults;
                dgvseries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvseries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvseries.Columns[3].Visible = false;
            }
            else
            {
                MessageBox.Show(objSerie.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarTablaSubseries()
        {
            objSub = new ClsSubSerie();
            objSubLn.Index(ref objSub);

            if (objSerie.ErrorMessage == null)
            {
                dgvsubseries.DataSource = objSub.DtResults;
                dgvsubseries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvsubseries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvsubseries.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show(objSerie.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarSecciones()
        {
            objSerie = new ClsSerie();
            objSerieLn.ListarSecciones(ref objSerie);
            if (objSerie.ErrorMessage == null)
            {
                cbSecciones.DataSource = objSerie.DtResults;
                cbSecciones.DisplayMember = "Seccion";
                cbSecciones.ValueMember = "ID";
                cbSecciones.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(objSerie.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarSeries()
        {
            objSerie = new ClsSerie();
            objSerieLn.ListarSeries(ref objSerie);
            if (objSerie.ErrorMessage == null)
            {
                cbSer.DataSource = objSerie.DtResults;
                cbSer.DisplayMember = "Serie";
                cbSer.ValueMember = "ID";
                cbSer.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(objSub.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            
        }

        private void AddSeries_Click(object sender, EventArgs e)
        {

            if (cbSecciones.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtNombreSerie.Text))
                {
                    objSerie = new ClsSerie();
                    objSerie.Idseccion = Convert.ToInt32(cbSecciones.SelectedValue);
                    objSerie.Nombre_serie = txtNombreSerie.Text.Trim();
                    objSerieLn.Create(ref objSerie);
                    if (objSerie.ErrorMessage == null)
                    {
                        MessageBox.Show("Serie guardada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTablaSeries();
                        cargarSeries();
                        LimpiarSerie();
                    }
                    else
                    {
                        MessageBox.Show(objSerie.ErrorMessage, "Error al guardar la serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sección no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ModSeries_Click(object sender, EventArgs e)
        {
            if (cbSecciones.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtNombreSerie.Text))
                {
                    objSerie = new ClsSerie();
                    objSerie.Idserie = idSerie;
                    objSerie.Idseccion = Convert.ToInt32(cbSecciones.SelectedValue);
                    objSerie.Nombre_serie = txtNombreSerie.Text.Trim();
                    objSerieLn.Update(ref objSerie);
                    if (objSerie.ErrorMessage == null)
                    {
                        MessageBox.Show("Serie editada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTablaSeries();
                        cargarSeries();
                        LimpiarSerie();
                    }
                    else
                    {
                        MessageBox.Show(objSerie.ErrorMessage, "Error al editar la serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Sección no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModSub_Click(object sender, EventArgs e)
        {
            if (cbSer.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtSub.Text))
                {
                    if (!String.IsNullOrEmpty(txtCod.Text))
                    {
                        objSub = new ClsSubSerie();
                        objSub.Idserie = Convert.ToInt32(cbSer.SelectedValue);
                        objSub.Nombresubserie = txtSub.Text.Trim();
                        objSub.Codigosubserie = txtCod.Text.Trim();
                        objSub.Idsubserie = idsubserie;
                        objSubLn.Update(ref objSub);
                        if (objSub.ErrorMessage == null)
                        {
                            MessageBox.Show("Subserie editada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTablaSubseries();
                            LimpiarSubserie();
                        }
                        else
                        {
                            MessageBox.Show(objSub.ErrorMessage, "Error al editar la subserie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serie no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvsubseries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dgvseries.CurrentRow.Index;

            idsubserie = Convert.ToInt32(dgvsubseries[0, fila].Value.ToString());
            cbSer.SelectedValue = Convert.ToInt32(dgvsubseries[4, fila].Value.ToString());
            txtSub.Text = dgvsubseries[1, fila].Value.ToString();
            txtCod.Text = dgvsubseries[2, fila].Value.ToString();
        }

        private void dgvseries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dgvseries.CurrentRow.Index;

            idSerie = Convert.ToInt32(dgvseries[0, fila].Value.ToString());
            cbSecciones.SelectedValue = Convert.ToInt32(dgvseries[3, fila].Value.ToString());
            txtNombreSerie.Text = dgvseries[1, fila].Value.ToString();
        }

        private void addSub_Click(object sender, EventArgs e)
        {
            if (cbSer.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtSub.Text))
                {
                    if (!String.IsNullOrEmpty(txtCod.Text))
                    {
                        objSub = new ClsSubSerie();
                        objSub.Idserie = Convert.ToInt32(cbSer.SelectedValue);
                        objSub.Nombresubserie = txtSub.Text.Trim();
                        objSub.Codigosubserie = txtCod.Text.Trim();
                        objSubLn.Create(ref objSub);
                        if (objSub.ErrorMessage == null)
                        {
                            MessageBox.Show("Subserie guardada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTablaSubseries();
                            LimpiarSubserie();
                        }
                        else
                        {
                            MessageBox.Show(objSub.ErrorMessage, "Error al guardar la subserie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre no válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serie no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
