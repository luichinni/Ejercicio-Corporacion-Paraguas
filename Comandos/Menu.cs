using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Menu
    {
        private string[] opciones;
        private string cabecera = "=== Seleccione una opción ===";
        public Menu(string[] opciones, string titulo = "") 
        {
            this.opciones = opciones;
            if (titulo != "") cabecera = titulo;
        }
        public void Mostrar()
        {
            Console.WriteLine(cabecera);
            for(int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine(i+".\t"+opciones[i]);
            }
        }
        public string GetSeleccion()
        {
            string seleccion = (opciones.Length + 1).ToString();
            while (!Utilidades.EsNumerico(seleccion) || int.Parse(seleccion) < 0 || int.Parse(seleccion) > opciones.Length - 1)
            {
                Console.WriteLine("Seleccione una opcion: ");
                seleccion = Console.ReadLine();
            }
            return opciones[int.Parse(seleccion)];
        }
    }
}
