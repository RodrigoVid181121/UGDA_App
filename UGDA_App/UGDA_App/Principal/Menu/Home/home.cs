//using UGDA_App.Forms.Clases;
using Entidades.Usuarios;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGDA_App
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void lbtitulo_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreU_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            lbNombreU.Text = Global.nombre_usuario;
        }
    }
}
