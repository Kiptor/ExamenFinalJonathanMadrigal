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
    public partial class Materias : Form
    {
        Controlador.ControladorMaterias controladormateria = new Controlador.ControladorMaterias();
        Controlador.EntidadMateria entidadmateria = new Controlador.EntidadMateria();
        Controlador.ControladorProfesores controladorprofesor = new Controlador.ControladorProfesores();
        Controlador.EntidadProfesor entidadprofesor = new Controlador.EntidadProfesor();
        public Materias()
        {
            InitializeComponent();
            cargarGrid2();
        }
        private void cargarGrid()
        {
            dataGridView1.DataSource = controladormateria.leer();
        }
        private void cargarGrid2()
        {
            dataGridView2.DataSource = controladorprofesor.leerNombre();
            String[,] Capturar = new String[50, 1];
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Capturar[i, j] = "";
                }
            }

            for (int r = 0; r < dataGridView2.RowCount - 1; r++)
            {
                for (int c = 0; c < dataGridView2.ColumnCount; c++)
                {

                    Capturar[r, c] = dataGridView2.Rows[r].Cells[c].Value.ToString();
                }
            }
            for (int r = 0; r < dataGridView2.RowCount - 1; r++)
            {
                for (int c = 0; c < dataGridView2.ColumnCount; c++)
                {

                    comboBox1.Items.Add(Capturar[r, c]);
                }
            }


        }
        private void cargarCombo()
        {

        }

        private void cargarEntidad()
        {
            string capturar;
            entidadmateria.Materia = Convert.ToInt16(textBox1.Text);
            entidadmateria.Nombre = textBox2.Text;
            capturar = Convert.ToString(comboBox1.SelectedItem);

            DataTable dt = new DataTable();
            dt = controladorprofesor.VerificarNombre(capturar);

            capturar = dt.Rows[0][0].ToString();

            entidadmateria.Profesor = Convert.ToInt16(capturar);

        }
        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            cargarEntidad();
            controladormateria.insertar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Buscar
            DataTable dt = new DataTable();
            dt = controladormateria.buscar(Convert.ToInt16(textBox1.Text));

            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eliminar
            controladormateria.eliminar(Convert.ToInt16(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modifcar
            cargarEntidad();
            controladormateria.modificar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }
    }
}
