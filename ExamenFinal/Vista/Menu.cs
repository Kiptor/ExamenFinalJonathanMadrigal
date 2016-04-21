using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vista.Estudiantes frm1 = new Vista.Estudiantes();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Materias frm1 = new Vista.Materias();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Profesores frm1 = new Vista.Profesores();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlador.ControladorConsola Estadistica = new Controlador.ControladorConsola();
            Estadistica.iniciar();
        }
    }
}
