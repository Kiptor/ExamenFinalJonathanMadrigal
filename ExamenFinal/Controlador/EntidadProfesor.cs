using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controlador
{
    class EntidadProfesor
    {
        private int id_profesor;
        private string nombre;
        private string apellido;

        public int Id_profesor
        {
            get
            {
                return id_profesor;
            }
            set
            {
                id_profesor = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public EntidadProfesor()
        {

            nombre = string.Empty;
            apellido = string.Empty;
            id_profesor = int.MinValue;

            
        }
    }
}
