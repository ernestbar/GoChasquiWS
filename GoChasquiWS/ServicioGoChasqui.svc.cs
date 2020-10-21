using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoChasquiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGoChasqui" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioGoChasqui.svc o ServicioGoChasqui.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioGoChasqui : IServicioGoChasqui
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
