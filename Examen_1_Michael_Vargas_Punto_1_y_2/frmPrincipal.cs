using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultar_XML pantalla = new frmConsultar_XML();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ModificarXML pantalla = new frm_ModificarXML();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
