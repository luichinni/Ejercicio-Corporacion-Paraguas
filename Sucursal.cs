using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Sucursal
    {
        public List<Vacuna> Vacunas { get; private set; }
        public List<Virus> Virus { get; private set; }
        public string Nombre { get; private set; }
        public Sucursal(string nombre)
        {
            Nombre = nombre;
            Vacunas = new List<Vacuna>();
            Virus = new List<Virus>();
        }
        public void SintetizarVirus()
        {
            int posUltimaVacuna = Vacunas.Count - 1;
            Virus nuevoVirus = Vacunas[posUltimaVacuna].SintetizarVirus();
            Virus.Add(nuevoVirus);
        }
        public void AgregarVacuna(string nombre, Designaciones designacion)
        {
            Vacunas.Add(new Vacuna(nombre, designacion));
        }
        public void DestruirMedicamento(string Id)
        {
            bool encontre = false;
            int indice = 0;
            while (!encontre)
            {
                if (Vacunas[indice].Id == Id) encontre = true;
                else indice++;
            }
            Vacunas[indice].Destruir();
        }
        public void DestruirTipo(Designaciones designacion)
        {
            List<Medicamento> listado = new List<Medicamento>();
            listado.AddRange(Vacunas);
            listado.AddRange(Virus);

            foreach (Medicamento v in listado)
            {
                if (v.Designacion == designacion) v.Destruir();
            }
        }
        public void AutodestruirSucursal()
        {
            Array array = Enum.GetValues(typeof(Designaciones));
            foreach (Designaciones d in array)
            {
                DestruirTipo(d);
            }
        }
    }
}
