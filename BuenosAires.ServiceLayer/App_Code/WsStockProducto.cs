using BuenosAires.Model.Utiles;
using BuenosAires.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "WsStockProducto" en el código, en svc y en el archivo de configuración a la vez.
public class WsStockProducto : IWsStockProducto
{
    public Respuesta obtener_equipos_en_bodega()
    {
        var resp = new Respuesta();
        resp.Accion = "obtener stock bodega";
        resp.Mensaje = "";
        resp.HayErrores = false;
        resp.JsonStockProducto = "";

        string apiUrl = "http://127.0.0.1:8000/BuenosAiresApiRest/obtener_equipos_en_bodega/";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                resp.JsonStockProducto = response.Content.ReadAsStringAsync().Result;
                string json = response.Content.ReadAsStringAsync().Result;
                List<StockBodega> lista = JsonConvert.DeserializeObject<List<StockBodega>>(json);
                resp.XmlStockProducto = Util.SerializarXML(lista);
            }
            else
            {
                resp.HayErrores = true;
                resp.Mensaje = "No fue posible obtener el stock de la bodega, intente nuevamente más tarde "
                    + "o comuníquese con el Administrador del Sistema";
            }
        }
        catch (Exception ex)
        {
            resp.HayErrores = true;
            resp.Mensaje = Util.MensajeError(resp.Accion, "WsStockProducto.obtener_equipos_en_bodega", ex);
            return resp;
        }


    }
}