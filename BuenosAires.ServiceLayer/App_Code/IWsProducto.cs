using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BuenosAires.BusinessLayer;
using BuenosAires.Model;

[ServiceContract]
public interface IWsProducto
{
    [OperationContract]
    Respuesta Crear(Producto producto);

    [OperationContract]
    Respuesta LeerTodos();

    [OperationContract]
    Respuesta Leer(int id);

    [OperationContract]
    Respuesta Actualizar(Producto producto);

    [OperationContract]
    Respuesta Eliminar(int id);
}