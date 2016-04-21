using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controlador
{
    class EntidadMateria
    {
        private int id_profesor;
        private string nombre;
        
        private int id_materia;
        public int Materia
        {
            get
            {
                return id_materia;
            }
            set
            {
                id_materia = value;
            }
        }
        public int Profesor
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
        public EntidadMateria()
        {
           
            nombre = string.Empty;

            id_profesor = int.MinValue;

            id_materia = int.MinValue;
        }

    }
}
