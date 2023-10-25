using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Vacuna : Medicamento
    {
        public Vacuna(string nombre, Designaciones designacion) : base(nombre, designacion){}
        public override void Destruir()
        {
            Id = "XXX";
        }
        public Virus SintetizarVirus()
        {
            return new Virus("Virus " + Nombre, Designacion, Id);
        }
    }
}
