using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamenFinal.Controlador
{
    class ControladorProfesores
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadProfesor entidad = new EntidadProfesor();
        string sql;

        public DataTable leer()
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"

                + " FROM "
                + "PROFESOR";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                 + "APELLIDO"
                 + " FROM "
                + "PROFESOR"
                + " WHERE "
                + "ID_PROFESOR = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadProfesor entidad)
        {
            sql = "INSERT INTO PROFESOR ("
                 + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"


            + ") VALUES ("
                + entidad.Id_profesor + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Apellido + "'"


                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadProfesor entidad)
        {
            sql = "UPDATE PROFESOR SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "ID_PROFESOR='" + entidad.Id_profesor + "',"
                + "APELLIDO='" + entidad.Apellido + "'"
                + " WHERE "
                + "ID_PROFESOR = " + entidad.Id_profesor;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE PROFESOR "
                + "WHERE "
                + "ID_PROFESOR = " + id;
            mod.ejecutarSQL(sql);
        }
        public DataTable leerNombre()
        {
            sql = "SELECT "
                
                + "NOMBRE"
                

                + " FROM "
                + "PROFESOR";
            return mod.llenarDT(sql);
        }
        public DataTable leerApellido()
        {
            sql = "SELECT "

               
                + "APELLIDO"

                + " FROM "
                + "PROFESOR";
            return mod.llenarDT(sql);
        }
        public DataTable VerificarNombre(string Nombre)
        {
            sql = "SELECT "
                + "ID_PROFESOR"
                + " FROM "
                + "PROFESOR"
                + " WHERE "
                + "NOMBRE = " + "'" + Nombre + "';";
            return mod.llenarDT(sql);
        }
    }
}
