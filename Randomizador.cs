using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Randomizador
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
    }
}
