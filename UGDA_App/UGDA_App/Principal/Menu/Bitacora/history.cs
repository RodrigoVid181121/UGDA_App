//using UGDA_App.Forms.Clases;
using Entidades.Bitacora;
using Entidades.Series;
using LogicaNegocios.Bitacora;
using System.Xml.Serialization;

namespace UGDA_App
{
    public partial class history : Form
    {
        private ClsBitacora objBit;
        private ClsBitacoraLn objBitLn = new ClsBitacoraLn();

        public history()
        {
            InitializeComponent();
            cargarBitacora();
            cmbfiltro.SelectedIndex = 1;
        }  

        private void cargarBitacora()
        {
            objBit = new ClsBitacora();
            objBitLn.Index(ref objBit);

            if (objBit.ErrorMessage == null)
            {

                dgbitacora.DataSource = objBit.DtResults;
                dgbitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgbitacora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                MessageBox.Show(objBit.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void history_Load(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //Filtrar por Evento
            if (cmbfiltro.SelectedIndex == 0)
            {
                objBit.DtResults.DefaultView.RowFilter = $"Evento LIKE '{txtbuscar.Text}%'";
            }

            //Filtrar por Usuario
            if (cmbfiltro.SelectedIndex == 1)
            {
                objBit.DtResults.DefaultView.RowFilter = $"Usuario LIKE '{txtbuscar.Text}%'";
            }

            //Filtrar por fecha
            if (cmbfiltro.SelectedIndex == 2)
            {
                objBit.DtResults.DefaultView.RowFilter = $"Fecha LIKE '{txtbuscar.Text}%'";
            }
        }

        private void DeleteBitacora_Click(object sender, EventArgs e)
        {
            
            objBit = new ClsBitacora();
            objBitLn.Delete(ref objBit);
            if (objBit.ErrorMessage == null)
            {
                MessageBox.Show("Bitácora eliminada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarBitacora();
            }
            else
            {
                MessageBox.Show(objBit.ErrorMessage, "Error al cargar la bitácora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
