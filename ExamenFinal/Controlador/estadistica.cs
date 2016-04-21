using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ExamenFinal.Controlador
{

    class estadistica
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadEstudiante entidad = new EntidadEstudiante();
        protected static int menores;
        protected static int mayores;
        protected static int cupo;
        protected static int asistencia;
        protected static int profesorado;
        protected static int laboratorio;
        protected static string sql;

        protected static int Menores
        {
            get
            {
                return menores;
            }
            set
            {
                menores = value;
            }
        }
        protected static int Mayores
        {
            get
            {
                return mayores;
            }
            set
            {
                mayores = value;
            }
        }
        protected static int Cupo
        {
            get
            {
                return cupo;
            }
            set
            {
                cupo = value;
            }
        }
        protected static int Asistencia
        {
            get
            {
                return asistencia;
            }
            set
            {
                asistencia = value;
            }
        }
        protected static int Profesorado
        {
            get
            {
                return profesorado;
            }
            set
            {
                profesorado = value;
            }
        }
        protected static int Laboratorio
        {
            get
            {
                return laboratorio;
            }
            set
            {
                laboratorio = value;
            }
        }


        protected DataTable ObtenerEdades()
        {
            sql = "SELECT "
                
                + "EDAD"
                
                + " FROM "
                + "ESTUDIANTE";
            return mod.llenarDT(sql);
        }
        protected void ObtenerMenores(DataTable Edades)
        {
            DataTable dt = new DataTable();
            dt = Edades;
            DataGridView nueva = new DataGridView();
            nueva.DataSource = dt;
            for (int i = 0; i < nueva.RowCount - 1; i++)
            {
                for (int e = 0; e < nueva.ColumnCount - 1; e++)
                {
                    if (Convert.ToInt16(nueva.Rows[i].Cells[e].Value) < 18)
                    {
                        menores++;
                        
                    }
                }
            }
        }
    

    }
}
