using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BuenosAires.Model;

[ServiceContract]
public interface IWsAutenticacion
{
    [OperationContract]
    Respuesta Autenticar(string tipousu, string username, string password);
}