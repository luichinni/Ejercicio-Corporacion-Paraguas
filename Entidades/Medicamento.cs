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

        public Medicamento(string nombre, Designaciones designacion)
        {
            Nombre = nombre;
            Designacion = designacion;
        }
        public Medicamento(string nombre,Designaciones designacion, int cantCharId)
        {
            Nombre = nombre;
            Designacion = designacion;
            Id = Utilidades.RandAlfaNum(cantCharId);
        }

        public abstract void Destruir();

        public override string ToString()
        {
            return $"Nombre: {Nombre} \tId: {Id} \tDesignación: {Designacion}";
        }
    }
}
