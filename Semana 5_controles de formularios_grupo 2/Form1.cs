using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5_controles_de_formularios_grupo_2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton de aceptar", "Ejemplo Mensaje Aceptar");
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje de informacion con botones Aceptar y Cancelar", 
                "Ejemplo Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void cuadroDeDialogoAceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton de aceptar", "Ejemplo Mensaje Aceptar");        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AboutBox1 f2 = new AboutBox1();
            //f2.ShowDialog();

            AboutBox1 newMDIChild = new AboutBox1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void bSi_No_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con botones Si, No y Cancelar", "Ejemplo Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void bexclamacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con boton Aceptar", 
                "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
        }

        private void binterrogacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void berror_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo", "Titulo Ventana",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
