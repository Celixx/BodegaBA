using BuenosAires.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsAnwo" in both code and config file together.
[ServiceContract]
public interface IWsAnwo
{
    [OperationContract]
    Respuesta consultar_productos_disponibles();

    [OperationContract]
    Respuesta reservar_producto(string nroserieanwo, string reservado);
}
