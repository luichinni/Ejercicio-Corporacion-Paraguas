using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Virus : Medicamento
    {
        public Virus(string nombre,Designaciones designacion,string IdVacuna) : base(nombre, designacion)
        {
            Id = IdVacuna+Utilidades.RandAlfaNum(1);
        }
        public override void Destruir()
        {
            Id = "YYYY";
        }
    }
}
