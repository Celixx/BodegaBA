using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BuenosAires.Model;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsGuiaDespacho" in both code and config file together.
[ServiceContract]
public interface IWsGuiaDespacho
{
    [OperationContract]
    Respuesta obtener_guias_de_despacho();
}
