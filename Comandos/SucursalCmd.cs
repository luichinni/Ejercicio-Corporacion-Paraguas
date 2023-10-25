using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    abstract class SucursalCmd
    {
        public abstract string Nombre { get; } // abstract para obligar a poner nombre
        public abstract void Ejecutar(Sucursal s);
    }
    class ListarCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Listar Sucursal";
        public override void Ejecutar(Sucursal s)
        {
            Console.WriteLine("Vacunas: ");
            foreach (Vacuna v in s.Vacunas)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Virus: ");
            foreach (Virus v in s.Virus)
            {
                Console.WriteLine(v);
            }
        }
    }
    class AutodestruirSucuCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Autodestruir Sucursal";
        public override void Ejecutar(Sucursal s)
        {
            s.AutodestruirSucursal();
        }
    }
    class DestruirTipoCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Destruir Tipo de Medicamento";
        public override void Ejecutar(Sucursal s)
        {
            int cant = Enum.GetValues(typeof(Designaciones)).Length;
            GenerarMenu().Mostrar();

            string seleccion = "";
            while (!Utilidades.EsNumerico(seleccion) || int.Parse(seleccion) < 0 || int.Parse(seleccion) >= cant)
            {
                Console.WriteLine("Ingrese una opcion:");
                seleccion = Console.ReadLine();
            }

            s.DestruirTipo((Designaciones)int.Parse(seleccion));
        }
        private Menu GenerarMenu()
        {
            Array valoresDesignaciones = Enum.GetValues(typeof(Designaciones));
            string[] designaciones = new string[valoresDesignaciones.Length];
            for (int i = 0; i < valoresDesignaciones.Length; i++)
            {
                designaciones[i] = valoresDesignaciones.GetValue(i).ToString();
            }
            return new Menu(designaciones, "Seleccion de Designacion a eliminar: ");
        }
    }
    class DestruirCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Destruir Vacuna/Virus";
        public override void Ejecutar(Sucursal s)
        {
            Console.WriteLine("Ingrese codigo alfanum a eliminar: ");
            string id = Console.ReadLine();
            s.DestruirMedicamento(id);
        }
    }
    class SintetizarCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Sintetizar Virus";
        public override void Ejecutar(Sucursal s)
        {
            s.SintetizarVirus();
        }
    }
    class CatalogarCmd : SucursalCmd
    {
        public override string Nombre { get; } = "Catalogar Vacuna";
        public override void Ejecutar(Sucursal s)
        {
            Console.WriteLine("Nombre de la vacuna: ");
            string nombre = Console.ReadLine();

            int cant = Enum.GetValues(typeof(Designaciones)).Length;
            GenerarMenu().Mostrar();

            string seleccion = "";
            while (!Utilidades.EsNumerico(seleccion) || int.Parse(seleccion) < 0 || int.Parse(seleccion) >= cant)
            {
                Console.WriteLine("Ingrese una opcion:");
                seleccion = Console.ReadLine();
            }

            s.AgregarVacuna(nombre, (Designaciones)int.Parse(seleccion));
        }
        private Menu GenerarMenu()
        {
            Array valoresDesignaciones = Enum.GetValues(typeof(Designaciones));
            string[] designaciones = new string[valoresDesignaciones.Length];
            for (int i = 0; i < valoresDesignaciones.Length; i++)
            {
                designaciones[i] = valoresDesignaciones.GetValue(i).ToString();
            }
            return new Menu(designaciones,"Seleccion de Designacion: ");
        }
    }
}
