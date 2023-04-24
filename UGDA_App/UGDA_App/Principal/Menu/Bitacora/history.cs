//using UGDA_App.Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGDA_App
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        //Bitacora bitacora = new Bitacora();
        DataTable dt = new DataTable();

        private void history_Load(object sender, EventArgs e)
        {
            //dt = bitacora.MostrarDatos();
            dgbitacora.DataSource = dt;
            dgbitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgbitacora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmbfiltro.SelectedIndex = 1;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //Filtrar por Evento
            if (cmbfiltro.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = $"Evento LIKE '{txtbuscar.Text}%'";
            }

            //Filtrar por Usuario
            if (cmbfiltro.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = $"Usuario LIKE '{txtbuscar.Text}%'";
            }

            //Filtrar por fecha
            if (cmbfiltro.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = $"Fecha LIKE '{txtbuscar.Text}%'";
            }
        }


    }
}
