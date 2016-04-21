using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamenFinal.Controlador
{
    class ControladorEstudiantes
    {

        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadEstudiante entidad = new EntidadEstudiante();
          string  sql;

        public  DataTable leer()
        {
            sql = "SELECT "
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                 + "ID_MATERIA"
                + " FROM "
                + "ESTUDIANTE";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                 + "ID_MATERIA"
                + " FROM "
                + "ESTUDIANTE"
                + " WHERE "
                + "ID_ESTUDIANTE= " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadEstudiante entidad)
        {
            sql = "INSERT INTO ESTUDIANTE ("
                 + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                 + "ID_MATERIA"
                
            + ") VALUES ("
                + entidad.Cedula + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Apellido + "',"
                + "'" + entidad.Direccion + "',"
                + "'" + entidad.Edad + "',"
                + "'" + entidad.Id_materia + "'"
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadEstudiante entidad)
        {
            sql = "UPDATE ESTUDIANTE SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "APELLIDO = '" + entidad.Apellido + "',"
                + "DIRECCION = '" + entidad.Direccion + "',"
                 + "EDAD = '" + entidad.Edad + "',"
                + "ID_MATERIA '= " + entidad.Edad + "'"
                + " WHERE "
                + "ID_ESTUDIANTE = " + entidad.Cedula;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE ESTUDIANTE "
                + "WHERE "
                + "ID_ESTUDIANTE = " + id;
            mod.ejecutarSQL(sql);
        }
        public DataTable VerificarMateria(string Nombre)
        {
            sql = "SELECT "
                +"ID_MATERIA"
                + " FROM "
                + "MATERIA"
                + " WHERE "
                + "NOMBRE = "+"'"+Nombre+"';";
            return mod.llenarDT(sql);
        }
    }
}
