using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    abstract class Medicamento
    {
        public string Nombre { get; protected set; }
        public string Id { get; protected set; }
        public Designaciones Designacion { get; protected set; }
        protected int cantidadCharEnId;

        public Medicamento(string nombre,Designaciones designacion)
        {
            Nombre = nombre;
            Designacion = designacion;
            Id = Randomizador.RandAlfaNum(cantidadCharEnId);
        }

        public abstract void Destruir();
    }
}
