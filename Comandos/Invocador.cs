using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorporacionParaguas
{
    class Invocador
    {
        public SucursalCmd GetComando(string cmd)
        {
            SucursalCmd cmdRet = null;
            switch (cmd)
            {
                case "Catalogar Vacuna":
                    cmdRet = new CatalogarCmd();
                    break;
                case "Sintetizar Virus":
                    cmdRet = new SintetizarCmd();
                    break;
                case "Destruir Vacuna/Virus":
                    cmdRet = new DestruirCmd();
                    break;
                case "Destruir Tipo de Medicamento":
                    cmdRet = new DestruirTipoCmd();
                    break;
                case "Autodestruir Sucursal":
                    cmdRet = new AutodestruirSucuCmd();
                    break;
                case "Listar Sucursal":
                    cmdRet = new ListarCmd();
                    break;
            }
            return cmdRet;
        }
    }
}
