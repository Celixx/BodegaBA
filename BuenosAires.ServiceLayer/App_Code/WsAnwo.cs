using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BuenosAires.Model;
using BuenosAires.Model.Utiles;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsAnwo" in code, svc and config file together.
public class WsAnwo : IWsAnwo
{
    public Respuesta consultar_productos_disponibles()
    {
        var resp = new Respuesta();
        resp.Accion = "consultar productos disponibles api anwo";
        resp.Mensaje = "";
        resp.HayErrores = false;
        resp.XmlAnwoStockProducto = "";

        string apiUrl = "http://127.0.0.1:5000/consultar_equipo_anwo";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    List<Anwo> lista = JsonConvert.DeserializeObject<List<Anwo>>(json);
                    resp.XmlListaAnwoStockProducto = Util.SerializarXML(lista);
                }
                else
                {
                    resp.HayErrores = true;
                    resp.Mensaje = "No fue posible obtener el stock de los productos de Anwo, intente nuevamente más tarde "
                        + "o comuníquese con el Administrador del Sistema";
                }
                return resp;
            }
        }
        catch (Exception ex)
        {
            resp.HayErrores = true;
            resp.Mensaje = Util.MensajeError(resp.Accion, "WsAnwo.consultar_productos_disponibles", ex);
            return resp;
        }
    }

    private StringContent toJsonContent(object data)
    {
        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
        return content;
    }

    public Respuesta reservar_producto(string nroserieanwo, string reservado)
    {
        var resp = new Respuesta();
        resp.Accion = "reservar producto anwo";
        resp.Mensaje = "";
        resp.HayErrores = false;
        resp.JsonAutenticado = "";

        string apiUrl = "http://127.0.0.1:5000/reservar_equipo_anwo";
        var content = toJsonContent(new
        {
            nroserieanwo = nroserieanwo,
            reservado = reservado
        });



        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    
                }
                else
                {
                    resp.HayErrores = true;
                    resp.Mensaje = "No fue posible reservar el producto, intente nuevamente más tarde "
                        + "o comuníquese con el Administrador del Sistema";
                }
                return resp;
            }
        }
        catch (Exception ex)
        {
            resp.HayErrores = true;
            resp.Mensaje = Util.MensajeError(resp.Accion, "WsAnwo.reservar_producto ", ex);
            return resp;
        }
    }
}
