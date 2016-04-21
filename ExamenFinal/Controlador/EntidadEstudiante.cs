using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controlador
{
    class EntidadEstudiante
    {
        private int cedula;
        private string nombre;
        private string apellido;
        private string direccion;
        private int edad;
        private int id_materia;


        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public int Cedula
        {
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
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

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public int Id_materia
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

        public EntidadEstudiante()
        {
            cedula = int.MinValue;
            nombre = string.Empty;
            apellido = string.Empty;
            edad = int.MinValue;
            direccion = string.Empty;
            id_materia = int.MinValue;
        }

    }
}
