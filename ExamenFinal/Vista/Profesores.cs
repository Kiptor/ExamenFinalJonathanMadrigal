using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal.Vista
{
    public partial class Profesores : Form
    {
        Controlador.ControladorProfesores controladorprofesor = new Controlador.ControladorProfesores();
        Controlador.EntidadProfesor entidadprofesor = new Controlador.EntidadProfesor();
        public Profesores()
        {
            InitializeComponent();
        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorprofesor.leer();
        }

        private void cargarCombo()
        {

        }

        private void cargarEntidad()
        {
            entidadprofesor.Id_profesor = Convert.ToInt16(textBox1.Text);
            entidadprofesor.Nombre = textBox2.Text;
            entidadprofesor.Apellido = textBox3.Text;
            

        }
        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            cargarEntidad();
            controladorprofesor.insertar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modifcar
            cargarEntidad();
            controladorprofesor.modificar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eliminar
            controladorprofesor.eliminar(Convert.ToInt16(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Buscar
            DataTable dt = new DataTable();
            dt = controladorprofesor.buscar(Convert.ToInt16(textBox1.Text));

            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
        }
    }
}
