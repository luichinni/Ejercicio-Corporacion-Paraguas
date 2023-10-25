using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Vacuna : Medicamento
    {
        public Vacuna(string nombre, Designaciones designacion, int cantCharId = 3) : base(nombre, designacion, cantCharId){}
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
