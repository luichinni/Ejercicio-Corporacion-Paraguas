﻿using EjercicioCorporacionParaguas;
SistemaGlobal sistemaGlobal = Utilidades.RandSistema();

List<Sucursal> listado = sistemaGlobal.ListarSucursales();
string[] codigos = new string[listado.Count];
for (int i = 0; i < listado.Count; i++)
{
    codigos[i] = listado[i].Id;
}

string[] opcionesSucursal =
{
    "Catalogar Vacuna",
    "Sintetizar Virus",
    "Destruir Vacuna/Virus",
    "Destruir Tipo de Medicamento",
    "Autodestruir Sucursal",
    "Autodestruir Global",
    "Listar Sucursal",
    "Listar Todo",
    "Salir"
};
Menu menuSucursal = new Menu(opcionesSucursal);
Invocador invocador = new Invocador();

Menu seleccionSucursal = new Menu(codigos,"=== Seleccione una sucursal ==="); // antes de iniciar seleccionamos sucursal
seleccionSucursal.Mostrar();
Sucursal sucuActual = sistemaGlobal.GetSucursal(seleccionSucursal.GetSeleccion());

bool fin = false;
string cmd = "";
while (!fin)
{
    menuSucursal.Mostrar();
    cmd = menuSucursal.GetSeleccion();
    if (cmd == "Salir" ) fin = true;
    else if (cmd == "Autodestruir Global")
    {
        sistemaGlobal.AutodestruirGlobal();
    }
    else if (cmd == "Listar Todo")
    {
        SucursalCmd cmmdo = invocador.GetComando("Listar Sucursal");
        foreach (Sucursal s in listado)
        {
            Console.WriteLine($"Sucursal {s.Id}:");
            cmmdo.Ejecutar(s);
        }
    }
    else
    {
        SucursalCmd comando = invocador.GetComando(cmd);
        comando.Ejecutar(sucuActual);
    }
}