﻿using BuenosAires.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWsStockProducto" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IWsStockProducto
{
    [OperationContract]
    Respuesta obtener_productos_bodega();

}