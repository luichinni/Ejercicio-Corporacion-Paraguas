using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Utilidades
    {
        public static string RandAlfaNum(int cantidad)
        {
            Random rnd = new Random();
            string str = "";
            while (str.Length < cantidad) 
            {
                if (rnd.NextDouble() > 0.5)
                    str = str + (char)rnd.Next(65, 91); // letras mayus
                else
                    str = str + (char)rnd.Next(48, 58); // numeros
            }
            return str;
        }
        public static SistemaGlobal RandSistema(int cantMaxSucursales=20)
        {
            SistemaGlobal sg = new SistemaGlobal();
            int cantMax = new Random().Next(1,cantMaxSucursales);
            for(int i = 0; i < cantMax; i++)
            {
                sg.CrearSucursal();
            }

            RandMedicamentos(sg);

            return sg;
        }
        private static void RandMedicamentos(SistemaGlobal sg)
        {
            List<Sucursal> listado = sg.ListarSucursales();
            Random rnd = new Random();
            foreach(Sucursal s in listado)
            {
                int cantMax = rnd.Next(1, 25);
                for (int i = 0;i < cantMax; i++)
                {
                    s.AgregarVacuna(RandAlfaNum(6), (Designaciones)rnd.Next(0, Enum.GetValues(typeof(Designaciones)).Length));
                    if(rnd.NextDouble() > 5.0) s.SintetizarVirus(); // 50% chance de crear un virus
                }
            }
        }
        public static bool EsNumerico(string str)
        {
            int cantNumeros = 0;
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9') cantNumeros++;
            }
            return cantNumeros == (str.Length - 1) && str != "";
        }
    }
}
