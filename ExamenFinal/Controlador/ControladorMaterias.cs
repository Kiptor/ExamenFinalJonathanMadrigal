using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamenFinal.Controlador
{
    
    class ControladorMaterias
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadMateria entidad = new EntidadMateria();
        string sql;

        public DataTable leer()
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                
                + " FROM "
                + "MATERIA";
            return mod.llenarDT(sql);
        }
        public DataTable leerMateria()
        {
            sql = "SELECT "
                
                + "NOMBRE"
                

                + " FROM "
                + "MATERIA";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                 + "ID_PROFESOR"
                 + " FROM "
                + "MATERIA"
                + " WHERE "
                + "ID_MATERIA = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadMateria entidad)
        {
            sql = "INSERT INTO MATERIA ("
                 + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
           

            + ") VALUES ("
                + entidad.Materia + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Profesor + "'"
               

                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadMateria entidad)
        {
            sql = "UPDATE MATERIA SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "ID_PROFESOR='" + entidad.Profesor + "',"
                + "ID_MATERIA = " + 1 
                + " WHERE "
                + "ID_MATERIA = " + entidad.Materia;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE MATERIA "
                + "WHERE "
                + "ID_MATERIA = " + id;
            mod.ejecutarSQL(sql);
        }

    }
}
