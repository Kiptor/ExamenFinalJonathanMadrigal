using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controlador
{
    class ControladorConsola
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        Modelo.Consola consola = new Modelo.Consola();

        public void iniciar()
        {
            consola.AsignarConsola();
            Console.WriteLine("1-Generar \n2-Mostrar\n3-Imprimir\n");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                /*estadistica_colegio.ObtenerMenores(estadistica_colegio.ObtenerEdades);
                Console.WriteLine("Menores de edad: "+estadistica_colegio.Menores);*/
            }
            if (opcion == "2")
            {

            }
            if (opcion == "3")
            {

            }



        }
    }
}
