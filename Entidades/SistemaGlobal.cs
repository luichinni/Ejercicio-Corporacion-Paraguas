using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class SistemaGlobal
    {
        private List<Sucursal> sucursales;
        public SistemaGlobal()
        {
            sucursales = new List<Sucursal>();
        }
        public void CrearSucursal(string nombre)
        {
            sucursales.Add(new Sucursal(nombre));
        }
        public List<Sucursal> ListarSucursales() 
        {
            List<Sucursal> sRet = new List<Sucursal>();
            sRet.AddRange(sucursales);
            return sRet; // la clono aunq las sucursales son iguales para no modificar referencias fuera
        }
        public List<Virus> ListarVirus()
        {
            List<Virus> virusRet = new List<Virus>();
            foreach (Sucursal s in sucursales)
            {
                virusRet.AddRange(s.Virus);
            }
            return virusRet;
        }
        public List<Vacuna> ListarVacunas()
        {
            List<Vacuna> vacunasRet = new List<Vacuna>();
            foreach(Sucursal s in sucursales)
            {
                vacunasRet.AddRange(s.Vacunas);
            }
            return vacunasRet;
        }
        public void AutodestruirSucursal(string nombre)
        {
            bool encontre = false;
            int indice = 0;
            while (!encontre)
            {
                if (sucursales[indice].Nombre == nombre) encontre = true;
                else indice++;
            }
            sucursales[indice].AutodestruirSucursal();
        }
        public void AutodestruirGlobal()
        {
            foreach (Sucursal s in sucursales)
            {
                s.AutodestruirSucursal();
            }
        }
    }
}
