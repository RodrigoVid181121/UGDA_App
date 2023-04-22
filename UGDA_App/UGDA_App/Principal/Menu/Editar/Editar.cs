//using UGDA_App.Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using UGDA_App.Forms.Clases;

namespace UGDA_App.Forms
{
    public partial class Editar : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        //Edit editar = new Edit();
        public Editar()
        {
            InitializeComponent();            
        }

        public void Limpiar()
        {
            cbSub.Text = "";
            cbSeries.Text = "";
            cbSer.Text = "";
            cbSecciones.Text = "";
            txtAñadir.Clear();
            txtCod.Clear();
            txtSub.Clear();
        }

        private void Cargar()
        {
        //    editar.llenarcbseries(cbSeries);
        //    editar.llenarcbseries(cbSer);
        //    editar.llenarcbsubseries(cbSub);
        //    editar.llenarcbsecciones(cbSecciones);
        //    editar.llenarcbcodsubseries(comboBox1);
        //    dt = editar.MostrarDatosSeries();
        //    dt2 = editar.MostrarDatosSubSeries();
        //    dgvseries.DataSource = dt;
        //    dgvsub.DataSource = dt2;
        //    dgvseries.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
        //    dgvseries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //    dgvsub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    dgvsub.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void AddSeries_Click(object sender, EventArgs e)
        {
            if (cbSecciones.Text !="" && txtAñadir.Text != "")
            {
                //if (editar.insertSeries(cbSecciones.Text.Trim(), txtAñadir.Text.Trim()))
                //{
                //    Limpiar();
                //    MessageBox.Show("Serie Documental registrada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    Cargar();
                //}
            }
        }

        private void ModSeries_Click(object sender, EventArgs e)
        {
            if (cbSecciones.Text !="" && cbSeries.Text!="")
            {
                //if(editar.updateSeries(cbSecciones.Text.Trim(), cbSeries.Text.Trim()))
                {
                    Limpiar();
                    MessageBox.Show("Serie Documental actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar();
                }
            }
        }

        private void addSub_Click(object sender, EventArgs e)
        {
            if (cbSer.Text!="" && txtCod.Text !="" && txtSub.Text !="")
            {
                //if (editar.inserSubtSeries(cbSer.Text.Trim(), txtSub.Text.Trim(), txtCod.Text.Trim()))
                {
                    Limpiar();
                    MessageBox.Show("SubSerie Documental Ingresada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar();
                }
            }
        }

        private void ModSub_Click(object sender, EventArgs e)
        {
            if (cbSer.Text!="" && cbSub.Text!="")
            {
                //if (editar.updateSubtSeries(cbSer.Text.Trim(), cbSub.Text.Trim()))
                //{
                //    Limpiar();
                //    MessageBox.Show("SubSerie Documental actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    editar.llenarcbseries(cbSeries);
                //    editar.llenarcbseries(cbSer);
                //    editar.llenarcbsubseries(cbSub);
                //    editar.llenarcbsecciones(cbSecciones);
                //    editar.llenarcbcodsubseries(comboBox1);
                //}
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txtAñadir_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSubseries_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i<comboBox1.Items.Count; i++)
            {
                if (txtCod.Text.Trim() != comboBox1.Items[i].ToString().Trim())
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txtCod, "Este código ya existe, por favor intente con otro");
                    break;
                }
            }
        }
    }
}
