
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
    public partial class Estudiantes : Form
    {
        Controlador.ControladorEstudiantes controladorestudiante = new Controlador.ControladorEstudiantes();
        Controlador.EntidadEstudiante entidadestudiante = new Controlador.EntidadEstudiante();
        Controlador.ControladorMaterias controladormateria = new Controlador.ControladorMaterias();
        Controlador.EntidadMateria entidadmateria = new Controlador.EntidadMateria();
       
        public Estudiantes()
        {
            InitializeComponent();
            cargarGrid2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            
        }


        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorestudiante.leer();
        }
        private void cargarGrid2()
        {
            dataGridView2.DataSource = controladormateria.leerMateria();
            String[,] Capturar = new String[50, 1];
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Capturar[i, j] = "";
                }
            }

            for (int r = 0; r < dataGridView2.RowCount-1 ; r++)
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
            entidadestudiante.Cedula = Convert.ToInt16(textBox1.Text);
            entidadestudiante.Nombre = textBox2.Text;
            entidadestudiante.Apellido = textBox3.Text;
            entidadestudiante.Edad = Convert.ToInt16(textBox6.Text);
            entidadestudiante.Direccion = textBox4.Text;
            capturar = Convert.ToString(comboBox1.SelectedItem);
            
            DataTable dt = new DataTable();
            dt = controladorestudiante.VerificarMateria(capturar);

            capturar = dt.Rows[0][0].ToString();
            entidadestudiante.Id_materia = Convert.ToInt16(capturar);
        }
        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Buscar
            DataTable dt = new DataTable();
            dt = controladorestudiante.buscar(Convert.ToInt16(textBox1.Text));
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox6.Text = dt.Rows[0][4].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            cargarEntidad();
            controladorestudiante.insertar(entidadestudiante);
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modifcar
            cargarEntidad();
            controladorestudiante.modificar(entidadestudiante);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eliminar
            controladorestudiante.eliminar(Convert.ToInt16(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }
    }
}
